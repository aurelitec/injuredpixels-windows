namespace InjuredPixels
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuBlack = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWhite = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRed = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGreen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCustomColor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNextColor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPreviousColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSelectCustomColor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRandomCustomColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuCheckMultipleMonitors = new System.Windows.Forms.ToolStripMenuItem();
            this.menuShowMouseCursor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAlwaysOnTop = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTouchMode = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAboutName = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAboutVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAboutCopyright = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuAboutHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.closeHelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customColorDialog = new System.Windows.Forms.ColorDialog();
            this.mainContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContextMenu
            // 
            this.mainContextMenu.DropShadowEnabled = false;
            this.mainContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBlack,
            this.menuWhite,
            this.menuRed,
            this.menuGreen,
            this.menuBlue,
            this.menuCustomColor,
            this.menuNextColor,
            this.menuPreviousColor,
            this.toolStripSeparator2,
            this.menuSelectCustomColor,
            this.menuRandomCustomColor,
            this.toolStripSeparator1,
            this.menuCheckMultipleMonitors,
            this.menuShowMouseCursor,
            this.menuAlwaysOnTop,
            this.menuTouchMode,
            this.toolStripSeparator3,
            this.menuAbout,
            this.menuQuit,
            this.toolStripSeparator4,
            this.closeHelpMenuItem});
            this.mainContextMenu.Name = "mainContextMenu";
            this.mainContextMenu.Size = new System.Drawing.Size(250, 402);
            this.mainContextMenu.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.MainContextMenuClosed);
            this.mainContextMenu.Opened += new System.EventHandler(this.MainContextMenuOpened);
            // 
            // menuBlack
            // 
            this.menuBlack.BackColor = System.Drawing.Color.Black;
            this.menuBlack.ForeColor = System.Drawing.Color.White;
            this.menuBlack.Name = "menuBlack";
            this.menuBlack.ShortcutKeyDisplayString = "1";
            this.menuBlack.Size = new System.Drawing.Size(249, 22);
            this.menuBlack.Text = "&Black";
            this.menuBlack.Click += new System.EventHandler(this.AnyColorMenuItemClick);
            // 
            // menuWhite
            // 
            this.menuWhite.BackColor = System.Drawing.Color.White;
            this.menuWhite.ForeColor = System.Drawing.Color.Black;
            this.menuWhite.Name = "menuWhite";
            this.menuWhite.ShortcutKeyDisplayString = "2";
            this.menuWhite.Size = new System.Drawing.Size(249, 22);
            this.menuWhite.Text = "&White";
            this.menuWhite.Click += new System.EventHandler(this.AnyColorMenuItemClick);
            // 
            // menuRed
            // 
            this.menuRed.BackColor = System.Drawing.Color.Red;
            this.menuRed.ForeColor = System.Drawing.Color.White;
            this.menuRed.Name = "menuRed";
            this.menuRed.ShortcutKeyDisplayString = "3";
            this.menuRed.Size = new System.Drawing.Size(249, 22);
            this.menuRed.Text = "Re&d";
            this.menuRed.Click += new System.EventHandler(this.AnyColorMenuItemClick);
            // 
            // menuGreen
            // 
            this.menuGreen.BackColor = System.Drawing.Color.Lime;
            this.menuGreen.ForeColor = System.Drawing.Color.Black;
            this.menuGreen.Name = "menuGreen";
            this.menuGreen.ShortcutKeyDisplayString = "4";
            this.menuGreen.Size = new System.Drawing.Size(249, 22);
            this.menuGreen.Text = "&Green";
            this.menuGreen.Click += new System.EventHandler(this.AnyColorMenuItemClick);
            // 
            // menuBlue
            // 
            this.menuBlue.BackColor = System.Drawing.Color.Blue;
            this.menuBlue.ForeColor = System.Drawing.Color.White;
            this.menuBlue.Name = "menuBlue";
            this.menuBlue.ShortcutKeyDisplayString = "5";
            this.menuBlue.Size = new System.Drawing.Size(249, 22);
            this.menuBlue.Text = "Bl&ue";
            this.menuBlue.Click += new System.EventHandler(this.AnyColorMenuItemClick);
            // 
            // menuCustomColor
            // 
            this.menuCustomColor.BackColor = System.Drawing.Color.DarkOrange;
            this.menuCustomColor.ForeColor = System.Drawing.Color.Black;
            this.menuCustomColor.Name = "menuCustomColor";
            this.menuCustomColor.ShortcutKeyDisplayString = "6";
            this.menuCustomColor.Size = new System.Drawing.Size(249, 22);
            this.menuCustomColor.Text = "&Custom Color";
            this.menuCustomColor.Click += new System.EventHandler(this.AnyColorMenuItemClick);
            // 
            // menuNextColor
            // 
            this.menuNextColor.Name = "menuNextColor";
            this.menuNextColor.ShortcutKeyDisplayString = "Right";
            this.menuNextColor.Size = new System.Drawing.Size(249, 22);
            this.menuNextColor.Text = "&Next Color";
            this.menuNextColor.Click += new System.EventHandler(this.MenuNextColorOnClick);
            // 
            // menuPreviousColor
            // 
            this.menuPreviousColor.Name = "menuPreviousColor";
            this.menuPreviousColor.ShortcutKeyDisplayString = "Left";
            this.menuPreviousColor.Size = new System.Drawing.Size(249, 22);
            this.menuPreviousColor.Text = "&Previous Color";
            this.menuPreviousColor.Click += new System.EventHandler(this.MenuPreviousColorOnClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(246, 6);
            // 
            // menuSelectCustomColor
            // 
            this.menuSelectCustomColor.Name = "menuSelectCustomColor";
            this.menuSelectCustomColor.ShortcutKeyDisplayString = "";
            this.menuSelectCustomColor.Size = new System.Drawing.Size(249, 22);
            this.menuSelectCustomColor.Text = "&Select Custom Color...";
            this.menuSelectCustomColor.Click += new System.EventHandler(this.MenuSelectCustomColorOnClick);
            // 
            // menuRandomCustomColor
            // 
            this.menuRandomCustomColor.Name = "menuRandomCustomColor";
            this.menuRandomCustomColor.ShortcutKeyDisplayString = "R";
            this.menuRandomCustomColor.Size = new System.Drawing.Size(249, 22);
            this.menuRandomCustomColor.Text = "&Random Custom Color";
            this.menuRandomCustomColor.Click += new System.EventHandler(this.MenuRandomCustomColorOnClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(246, 6);
            // 
            // menuCheckMultipleMonitors
            // 
            this.menuCheckMultipleMonitors.Name = "menuCheckMultipleMonitors";
            this.menuCheckMultipleMonitors.Size = new System.Drawing.Size(249, 22);
            this.menuCheckMultipleMonitors.Text = "Check Multiple M&onitors";
            this.menuCheckMultipleMonitors.Visible = false;
            // 
            // menuShowMouseCursor
            // 
            this.menuShowMouseCursor.CheckOnClick = true;
            this.menuShowMouseCursor.Name = "menuShowMouseCursor";
            this.menuShowMouseCursor.ShortcutKeyDisplayString = "M";
            this.menuShowMouseCursor.Size = new System.Drawing.Size(249, 22);
            this.menuShowMouseCursor.Text = "Show &Mouse Cursor";
            this.menuShowMouseCursor.CheckedChanged += new System.EventHandler(this.MenuShowMouseCursorOnCheckedChanged);
            // 
            // menuAlwaysOnTop
            // 
            this.menuAlwaysOnTop.Checked = true;
            this.menuAlwaysOnTop.CheckOnClick = true;
            this.menuAlwaysOnTop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuAlwaysOnTop.Name = "menuAlwaysOnTop";
            this.menuAlwaysOnTop.ShortcutKeyDisplayString = "A";
            this.menuAlwaysOnTop.Size = new System.Drawing.Size(249, 22);
            this.menuAlwaysOnTop.Text = "&Always On Top";
            this.menuAlwaysOnTop.CheckedChanged += new System.EventHandler(this.MenuAlwaysOnTopOnCheckedChanged);
            // 
            // menuTouchMode
            // 
            this.menuTouchMode.CheckOnClick = true;
            this.menuTouchMode.Name = "menuTouchMode";
            this.menuTouchMode.ShortcutKeyDisplayString = "T";
            this.menuTouchMode.Size = new System.Drawing.Size(249, 22);
            this.menuTouchMode.Text = "&Touch Mode";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(246, 6);
            // 
            // menuAbout
            // 
            this.menuAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAboutName,
            this.menuAboutVersion,
            this.menuAboutCopyright,
            this.toolStripSeparator5,
            this.menuAboutHelp});
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(249, 22);
            this.menuAbout.Text = "About";
            // 
            // menuAboutName
            // 
            this.menuAboutName.Enabled = false;
            this.menuAboutName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuAboutName.Name = "menuAboutName";
            this.menuAboutName.Size = new System.Drawing.Size(223, 22);
            this.menuAboutName.Text = "InjuredPixels (.NET Edition)";
            // 
            // menuAboutVersion
            // 
            this.menuAboutVersion.Enabled = false;
            this.menuAboutVersion.Name = "menuAboutVersion";
            this.menuAboutVersion.Size = new System.Drawing.Size(223, 22);
            this.menuAboutVersion.Text = "Version {0}";
            // 
            // menuAboutCopyright
            // 
            this.menuAboutCopyright.Enabled = false;
            this.menuAboutCopyright.Name = "menuAboutCopyright";
            this.menuAboutCopyright.Size = new System.Drawing.Size(223, 22);
            this.menuAboutCopyright.Text = "Copyright © Aurelitec";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(220, 6);
            // 
            // menuAboutHelp
            // 
            this.menuAboutHelp.Name = "menuAboutHelp";
            this.menuAboutHelp.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.menuAboutHelp.Size = new System.Drawing.Size(223, 22);
            this.menuAboutHelp.Text = "Online Help";
            this.menuAboutHelp.ToolTipText = "http://www.aurelitec.com/injuredpixels/windows/help/";
            this.menuAboutHelp.Click += new System.EventHandler(this.MenuAboutUrlItemsOnClick);
            // 
            // menuQuit
            // 
            this.menuQuit.Name = "menuQuit";
            this.menuQuit.ShortcutKeyDisplayString = "Q";
            this.menuQuit.Size = new System.Drawing.Size(249, 22);
            this.menuQuit.Text = "&Quit";
            this.menuQuit.Click += new System.EventHandler(this.MenuQuitOnClick);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(246, 6);
            // 
            // closeHelpMenuItem
            // 
            this.closeHelpMenuItem.Enabled = false;
            this.closeHelpMenuItem.Name = "closeHelpMenuItem";
            this.closeHelpMenuItem.ShowShortcutKeys = false;
            this.closeHelpMenuItem.Size = new System.Drawing.Size(249, 22);
            this.closeHelpMenuItem.Text = "(click outside or Esc to hide menu)";
            this.closeHelpMenuItem.ToolTipText = "To show the menu again, right-click on the screen or press Escape.";
            // 
            // customColorDialog
            // 
            this.customColorDialog.FullOpen = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(590, 445);
            this.ContextMenuStrip = this.mainContextMenu;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "InjuredPixels";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormClosed);
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainFormMouseDown);
            this.mainContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip mainContextMenu;
        private System.Windows.Forms.ToolStripMenuItem menuBlack;
        private System.Windows.Forms.ToolStripMenuItem menuWhite;
        private System.Windows.Forms.ToolStripMenuItem menuRed;
        private System.Windows.Forms.ToolStripMenuItem menuGreen;
        private System.Windows.Forms.ToolStripMenuItem menuBlue;
        private System.Windows.Forms.ToolStripMenuItem menuCustomColor;
        private System.Windows.Forms.ToolStripMenuItem menuNextColor;
        private System.Windows.Forms.ToolStripMenuItem menuPreviousColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuSelectCustomColor;
        private System.Windows.Forms.ColorDialog customColorDialog;
        private System.Windows.Forms.ToolStripMenuItem menuRandomCustomColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ToolStripMenuItem menuQuit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem closeHelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAboutName;
        private System.Windows.Forms.ToolStripMenuItem menuShowMouseCursor;
        private System.Windows.Forms.ToolStripMenuItem menuAlwaysOnTop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuCheckMultipleMonitors;
        private System.Windows.Forms.ToolStripMenuItem menuAboutHelp;
        private System.Windows.Forms.ToolStripMenuItem menuAboutVersion;
        private System.Windows.Forms.ToolStripMenuItem menuAboutCopyright;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem menuTouchMode;
    }
}

