//----------------------------------------------------------------------------
//
// <copyright file="MainForm.cs" company="Aurelitec">
// Copyright (c) 2009-2017 Aurelitec
// http://www.aurelitec.com
// Licensed under the Apache License, Version 2.0. See LICENSE file in the project root for full license information.
// </copyright>
//
// Description: The main colored full screen form of InjuredPixels.
//
//---------------------------------------------------------------------------

namespace InjuredPixels
{
    using System;
    using System.Diagnostics;
    using System.Drawing;
    using System.Globalization;
    using System.Windows.Forms;
    using Reuse;
    using SharpConfig;

    /// <summary>
    /// The Main Form class
    /// </summary>
    public partial class MainForm : Form
    {
        // ********************
        // Constants and Fields
        // ********************

        /// <summary>
        /// Represents the largest value for the color index. This field is constant.
        /// </summary>
        private const int MaxColorIndex = 5;

        /// <summary>
        /// Stores the previously selected color index.
        /// </summary>
        private int previousColorIndex;

        /// <summary>
        /// The time (in ticks) when the context menu was last closed (see MainFormMouseDown body for more details).
        /// </summary>
        private long lastMenuCloseTime;

        // ********************
        // Application Startup
        // ********************

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // Set the form's font to the default operating system font (Segoe UI on Vista)
            this.Font = SystemFonts.MessageBoxFont;
            this.InitializeComponent();
        }

        /// <summary>
        /// Event Handler for the Load event of the main form - performs startup tasks.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An object that contains no event data.</param>
        private void MainFormLoad(object sender, EventArgs e)
        {
            // Set the main form icon to the program icon, thus avoiding storing a duplicate of the main program
            // icon in the main assembly file
            this.Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);

            // Set the screen color to the default Black color (color index 0)
            this.SetColorIndex(this.previousColorIndex = 0);

            // set the text of the About Details menu item with program information
            this.menuAboutVersion.Text = string.Format(CultureInfo.CurrentCulture, this.menuAboutVersion.Text, Application.ProductVersion);

            // Because we can't assign a single character key to the ShortcutKeys property of a ToolStripMenuItem,
            // we store it in the Tag property
            KeysConverter keysConv = new KeysConverter();
            foreach (ToolStripItem item in this.mainContextMenu.Items)
            {
                ToolStripMenuItem menuItem = item as ToolStripMenuItem;
                if ((menuItem != null) && (menuItem.ShortcutKeyDisplayString != null))
                {
                    menuItem.Tag = keysConv.ConvertFrom(menuItem.ShortcutKeyDisplayString);
                }
            }

            // Multi-monitor support - create a submenu for each screen and one for all screens
            this.AddMultiMonitorSupport();

            // Fill only the primary screen by default
            this.Bounds = Utils.GetScreenBounds(Screen.PrimaryScreen);

            // Improve the look of the main context menu
            this.ModernizeContextMenu();

            // Hide the mouse cursor by default
            Cursor.Hide();

            // Load configuration
            this.LoadConfiguration();

            // Show the main context menu at startup
            this.mainContextMenu.Show(Cursor.Position);
        }

        // *******************************
        // Initialization Helper Functions
        // *******************************

        /// <summary>
        /// Event Handler for the Click event of the multi-monitor support menu items.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An object that contains no event data.</param>
        private void AnyMonitorMenuItemClick(object sender, EventArgs e)
        {
            ToolStripMenuItem senderMenuItem = sender as ToolStripMenuItem;

            this.Bounds = Utils.GetScreenBounds(senderMenuItem.Tag as Screen);

            // Radio check current monitor menu item
            foreach (ToolStripMenuItem item in this.menuCheckMultipleMonitors.DropDownItems)
            {
                item.Image = null;
            }

            senderMenuItem.Image = Properties.Resources.RadioCheckIconBlack;
        }

        /// <summary>
        /// Add multi-monitor support: create a submenu for each screen and one for all screens.
        /// </summary>
        private void AddMultiMonitorSupport()
        {
            if (Screen.AllScreens.Length > 1)
            {
                this.menuCheckMultipleMonitors.Visible = true;
                for (int i = 0; i < Screen.AllScreens.Length; i++)
                {
                    Screen scr = Screen.AllScreens[i];
                    ToolStripMenuItem item = new ToolStripMenuItem(
                        scr.DeviceName,
                        scr.Primary ? Properties.Resources.RadioCheckIconBlack : null,
                        new EventHandler(this.AnyMonitorMenuItemClick));
                    item.Tag = scr;
                    if (i < 9)
                    {
                        item.ShortcutKeys = Keys.Control | (Keys.D1 + i);
                    }

                    this.menuCheckMultipleMonitors.DropDownItems.Add(item);
                }

                ToolStripMenuItem allMenu = new ToolStripMenuItem(Properties.Resources.UiAllMonitorsMenu, null, new EventHandler(this.AnyMonitorMenuItemClick), Keys.Control | Keys.A);
                this.menuCheckMultipleMonitors.DropDownItems.Add(allMenu);
            }
        }

        /// <summary>
        /// Improve the look of the main context menu.
        /// </summary>
        private void ModernizeContextMenu()
        {
            MenuToolStripCustomizer customizer = MenuToolStripCustomizer.Modernize(
                ColorTranslator.FromHtml("#F2F2F2"),
                ColorTranslator.FromHtml("#D9D9D9"),
                SystemColors.MenuText,
                8,
                1d,
                null,
                this.mainContextMenu);

            customizer.ColorTable.ColorOfMenuItemBorder = Color.Empty;
            customizer.ColorTable.ColorOfSeparatorDark = ColorTranslator.FromHtml("#919191");
            customizer.ColorTable.ColorOfCheckBackground = Color.Empty;
            customizer.ColorTable.ColorOfCheckSelectedBackground = Color.Empty;
            customizer.ColorTable.ColorOfButtonSelectedBorder = Color.Empty;
            customizer.ColorTable.ColorOfMenuBorder = ColorTranslator.FromHtml("#a0a0a0");
        }

        // ***********************************
        // Main Functionality Helper Functions
        // ***********************************

        /// <summary>
        /// Sets a new screen color and checks the corresponding color menu item
        /// in the main context menu.
        /// </summary>
        /// <param name="newColorIndex">The index of the new color.</param>
        private void SetColorIndex(int newColorIndex)
        {
            // If by some error we try to set a color index out of range, default to 0 (black)
            if ((newColorIndex < 0) || (newColorIndex > MaxColorIndex))
            {
                newColorIndex = 0;
            }

            // Uncheck the menu item of the previous color
            this.mainContextMenu.Items[this.previousColorIndex].Image = null;

            this.previousColorIndex = newColorIndex;

            // Check the menu item of the new color
            this.mainContextMenu.Items[newColorIndex].Image =
                this.mainContextMenu.Items[newColorIndex].ForeColor == Color.Black ?
                Properties.Resources.RadioCheckIconBlack : Properties.Resources.RadioCheckIconWhite;

            // Set the background color of the maximized main form ("the screen") to the new color
            this.BackColor = this.mainContextMenu.Items[newColorIndex].BackColor;
        }

        /// <summary>
        /// Sets the custom color to a new value and updates the Custom Color menu item.
        /// </summary>
        /// <param name="colorValue">The ARGB value of the color.</param>
        /// <param name="activate">Whether to activate the custom color</param>
        private void SetCustomColor(Color colorValue, bool activate = true)
        {
            // Update the background, text color and tooltip of the Custom Color menu item
            this.menuCustomColor.BackColor = colorValue;
            this.menuCustomColor.ForeColor = (colorValue.GetBrightness() < 0.5) ?
                Color.White : Color.Black;

            // Set the screen color to the new custom color
            if (activate)
            {
                this.SetColorIndex(this.mainContextMenu.Items.IndexOf(this.menuCustomColor));
            }
        }

        /// <summary>
        /// Shows or hides the mouse depending on the Checked property of the Show Mouse Cursor menu item.
        /// </summary>
        /// <param name="visibility">Boolean flag set to true to show the mouse, or to false to hide it</param>
        private void EnsureMouseVisibility(bool visibility)
        {
            if (!this.menuShowMouseCursor.Checked)
            {
                if (visibility)
                {
                    Cursor.Show();
                }
                else
                {
                    Cursor.Hide();
                }
            }
        }

        // ***********************************
        // Main Form Mouse and Keyboard Events
        // ***********************************

        /// <summary>
        /// Event Handler for the KeyDown event of the main form - handles shortcut keys.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An object that provides the event data. </param>
        private void MainFormKeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Return) || (e.KeyCode == Keys.Escape))
            {
                // Enter or Escape shows the main context menu
                this.mainContextMenu.Show(Cursor.Position);
            }
            else
            {
                // Handle the context menu items shortcut keys
                // Because we can't assign single character keys to ShortcutKeys property, we store them in the
                // Tag property of each ToolStripItem
                foreach (ToolStripItem item in this.mainContextMenu.Items)
                {
                    if ((item.Tag is Keys) && ((Keys)item.Tag == e.KeyCode) && (!e.Alt) && (!e.Control))
                    {
                        item.PerformClick();
                        e.Handled = true;
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// Event Handler for the MouseDown event of the main form - cycles through colors
        /// and selects the next color.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An object that provides the event data. </param>
        private void MainFormMouseDown(object sender, MouseEventArgs e)
        {
            // Select the next color if left mouse button is pressed, only if not in touch mode
            if (!this.menuTouchMode.Checked)
            {
                // Ignore left mouse clicks performed when the context menu is opened, as these clicks should only close
                // the context menu. We can identify them if they generate MouseDown events immediately after
                // the context menu is closed (under 10 milliseconds/10,000 ticks should be enough).
                if ((e.Button == MouseButtons.Left) && (DateTime.Now.Ticks - this.lastMenuCloseTime > 100000))
                {
                    this.menuNextColor.PerformClick();
                }
            }
        }

        // *************************************
        // Main Context Menu Items Functionality
        // *************************************

        /// <summary>
        /// Event Handler for the Open event of the main context menu.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An object that contains no event data.</param>
        private void MainContextMenuOpened(object sender, EventArgs e)
        {
            // To be able to use the context menu, make sure the mouse cursor is visible
            this.EnsureMouseVisibility(true);
        }

        /// <summary>
        /// Event Handler for the Closed event of the main context menu.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An object that provides data for the Closed event.</param>
        private void MainContextMenuClosed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            // Hide the mouse cursor if the Show Mouse Cursor menu item is unchecked
            this.lastMenuCloseTime = DateTime.Now.Ticks;
            this.EnsureMouseVisibility(false);
        }

        /// <summary>
        /// Event Handler for the Click event of all color menu items - allows the user to
        /// select another screen color from the main context menu.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An object that contains no event data.</param>
        private void AnyColorMenuItemClick(object sender, EventArgs e)
        {
            this.SetColorIndex(this.mainContextMenu.Items.IndexOf(sender as ToolStripItem));
        }

        /// <summary>
        /// Event Handler for the Click event of "Next Color" Menu Item - cycles through colors
        /// and selects the next color.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An object that contains no event data.</param>
        private void MenuNextColorOnClick(object sender, EventArgs e)
        {
            this.SetColorIndex((this.previousColorIndex < MaxColorIndex) ? this.previousColorIndex + 1 : 0);
        }

        /// <summary>
        /// Event Handler for the Click event of "Previous Color" Menu Item - cycles through
        /// colors and selects the previous color.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An object that contains no event data.</param>
        private void MenuPreviousColorOnClick(object sender, EventArgs e)
        {
            this.SetColorIndex((this.previousColorIndex > 0) ? this.previousColorIndex - 1 : MaxColorIndex);
        }

        /// <summary>
        /// Event Handler for the Click event of "Select Custom Color" Menu Item - opens
        /// the Color dialog box and allows the user to select a new custom color.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An object that contains no event data.</param>
        private void MenuSelectCustomColorOnClick(object sender, EventArgs e)
        {
            // To be able to use the Color dialog box, we must make sure the mouse cursor is visible
            this.EnsureMouseVisibility(true);

            // Open the Color dialog box and set the new custom color if the user selects one
            this.customColorDialog.Color = this.BackColor;
            if (this.customColorDialog.ShowDialog(this) == DialogResult.OK)
            {
                this.SetCustomColor(this.customColorDialog.Color);
            }

            // Hide the mouse cursor if the Show Mouse Cursor menu item is unchecked
            this.EnsureMouseVisibility(false);
        }

        /// <summary>
        /// Event Handler for the Click event of "Random Custom Color" Menu Item - generates
        /// a random color and updates the menu item.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An object that contains no event data.</param>
        private void MenuRandomCustomColorOnClick(object sender, EventArgs e)
        {
            this.SetCustomColor(Utils.GetRandomColor());
        }

        /// <summary>
        /// Event Handler for the CheckedChanged event of "Show Mouse Cursor" Menu Item - shows or
        /// hides the mouse cursor.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An object that contains no event data.</param>
        private void MenuShowMouseCursorOnCheckedChanged(object sender, EventArgs e)
        {
            if (this.menuShowMouseCursor.Checked)
            {
                Cursor.Show();
            }
            else
            {
                Cursor.Hide();
            }
        }

        /// <summary>
        /// Event Handler for the CheckedChanged event of "Always On Top" Menu Item - allows the user
        /// to control whether to display the main InjuredPixels window on top of all other windows.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An object that contains no event data.</param>
        private void MenuAlwaysOnTopOnCheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = this.menuAlwaysOnTop.Checked;
        }

        /// <summary>
        /// Event Handler for the Click event of the "Online Help", "Home Page" and "Like, Share or Recommend" menu items - opens the
        /// corresponding program web pages.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An object that contains no event data.</param>
        private void MenuAboutUrlItemsOnClick(object sender, EventArgs e)
        {
            ToolStripMenuItem senderMenuItem = sender as ToolStripMenuItem;
            if (senderMenuItem != null)
            {
                this.WindowState = FormWindowState.Minimized;
                Process.Start(senderMenuItem.ToolTipText);
            }
        }

        /// <summary>
        /// Event Handler for the Click event of "Quit" Menu Item - closes the application.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An object that contains no event data.</param>
        private void MenuQuitOnClick(object sender, EventArgs e)
        {
            this.Close();
        }

        // ***************
        // Application End
        // ***************

        /// <summary>
        /// Event Handler for the Closed event of the main form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An object that contains event data.</param>
        private void MainFormClosed(object sender, FormClosedEventArgs e)
        {
            // Make sure the mouse cursor is visible when we close the application
            this.EnsureMouseVisibility(true);

            this.SaveConfiguration();
        }

        // ********************************
        // Configuration Loading And Saving
        // ********************************

        /// <summary>
        /// Saves the program configuration.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Justification = "We are logging the exception")]
        private void LoadConfiguration()
        {
            try
            {
                string configFileName = Utils.GetConfigFileName(Properties.Resources.ConfigName, Application.ExecutablePath, Properties.Resources.AppDataPath);
                if (!string.IsNullOrEmpty(configFileName))
                {
                    var config = Configuration.LoadFromFile(configFileName);
                    var section = config[Properties.Resources.ConfigGeneral];
                    this.menuShowMouseCursor.Checked = section[Properties.Resources.ConfigShowMouseCursor].BoolValue;
                    this.menuAlwaysOnTop.Checked = section[Properties.Resources.ConfigAlwaysOnTop].BoolValue;
                    this.menuTouchMode.Checked = section[Properties.Resources.ConfigTouchMode].BoolValue;
                    int colorIntValue = section[Properties.Resources.ConfigCustomColor].IntValue;
                    this.SetCustomColor(Color.FromArgb(colorIntValue), false);
                    int colorIndex = section[Properties.Resources.ConfigColorIndex].IntValue;
                    this.SetColorIndex(colorIndex);
                }
            }
            catch (Exception ex)
            {
                Utils.LogMessage(Properties.Resources.LogErrorLoadConfig, ex.Message);
            }
        }

        /// <summary>
        /// Saves the program configuration.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Justification = "We are logging the exception")]
        private void SaveConfiguration()
        {
            try
            {
                string configFileName = Utils.GetConfigFileName(Properties.Resources.ConfigName, Application.ExecutablePath, Properties.Resources.AppDataPath);
                if (!string.IsNullOrEmpty(configFileName))
                {
                    var config = new Configuration();
                    var section = config[Properties.Resources.ConfigGeneral];
                    section[Properties.Resources.ConfigShowMouseCursor].BoolValue = this.menuShowMouseCursor.Checked;
                    section[Properties.Resources.ConfigAlwaysOnTop].BoolValue = this.menuAlwaysOnTop.Checked;
                    section[Properties.Resources.ConfigTouchMode].BoolValue = this.menuTouchMode.Checked;
                    section[Properties.Resources.ConfigCustomColor].IntValue = this.menuCustomColor.BackColor.ToArgb();
                    section[Properties.Resources.ConfigColorIndex].IntValue = this.previousColorIndex;
                    config.SaveToFile(configFileName);
                }
            }
            catch (Exception ex)
            {
                Utils.LogMessage(Properties.Resources.LogErrorSaveConfig, ex.Message);
            }
        }
    }
}
