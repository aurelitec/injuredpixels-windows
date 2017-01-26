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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            resources.ApplyResources(this.mainContextMenu, "mainContextMenu");
            this.mainContextMenu.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.MainContextMenuClosed);
            this.mainContextMenu.Opened += new System.EventHandler(this.MainContextMenuOpened);
            // 
            // menuBlack
            // 
            this.menuBlack.BackColor = System.Drawing.Color.Black;
            this.menuBlack.ForeColor = System.Drawing.Color.White;
            this.menuBlack.Name = "menuBlack";
            resources.ApplyResources(this.menuBlack, "menuBlack");
            this.menuBlack.Click += new System.EventHandler(this.AnyColorMenuItemClick);
            // 
            // menuWhite
            // 
            this.menuWhite.BackColor = System.Drawing.Color.White;
            this.menuWhite.ForeColor = System.Drawing.Color.Black;
            this.menuWhite.Name = "menuWhite";
            resources.ApplyResources(this.menuWhite, "menuWhite");
            this.menuWhite.Click += new System.EventHandler(this.AnyColorMenuItemClick);
            // 
            // menuRed
            // 
            this.menuRed.BackColor = System.Drawing.Color.Red;
            this.menuRed.ForeColor = System.Drawing.Color.White;
            this.menuRed.Name = "menuRed";
            resources.ApplyResources(this.menuRed, "menuRed");
            this.menuRed.Click += new System.EventHandler(this.AnyColorMenuItemClick);
            // 
            // menuGreen
            // 
            this.menuGreen.BackColor = System.Drawing.Color.Lime;
            this.menuGreen.ForeColor = System.Drawing.Color.Black;
            this.menuGreen.Name = "menuGreen";
            resources.ApplyResources(this.menuGreen, "menuGreen");
            this.menuGreen.Click += new System.EventHandler(this.AnyColorMenuItemClick);
            // 
            // menuBlue
            // 
            this.menuBlue.BackColor = System.Drawing.Color.Blue;
            this.menuBlue.ForeColor = System.Drawing.Color.White;
            this.menuBlue.Name = "menuBlue";
            resources.ApplyResources(this.menuBlue, "menuBlue");
            this.menuBlue.Click += new System.EventHandler(this.AnyColorMenuItemClick);
            // 
            // menuCustomColor
            // 
            this.menuCustomColor.BackColor = System.Drawing.Color.DarkOrange;
            this.menuCustomColor.ForeColor = System.Drawing.Color.Black;
            this.menuCustomColor.Name = "menuCustomColor";
            resources.ApplyResources(this.menuCustomColor, "menuCustomColor");
            this.menuCustomColor.Click += new System.EventHandler(this.AnyColorMenuItemClick);
            // 
            // menuNextColor
            // 
            this.menuNextColor.Name = "menuNextColor";
            resources.ApplyResources(this.menuNextColor, "menuNextColor");
            this.menuNextColor.Click += new System.EventHandler(this.MenuNextColorOnClick);
            // 
            // menuPreviousColor
            // 
            this.menuPreviousColor.Name = "menuPreviousColor";
            resources.ApplyResources(this.menuPreviousColor, "menuPreviousColor");
            this.menuPreviousColor.Click += new System.EventHandler(this.MenuPreviousColorOnClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // menuSelectCustomColor
            // 
            this.menuSelectCustomColor.Name = "menuSelectCustomColor";
            resources.ApplyResources(this.menuSelectCustomColor, "menuSelectCustomColor");
            this.menuSelectCustomColor.Click += new System.EventHandler(this.MenuSelectCustomColorOnClick);
            // 
            // menuRandomCustomColor
            // 
            this.menuRandomCustomColor.Name = "menuRandomCustomColor";
            resources.ApplyResources(this.menuRandomCustomColor, "menuRandomCustomColor");
            this.menuRandomCustomColor.Click += new System.EventHandler(this.MenuRandomCustomColorOnClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // menuCheckMultipleMonitors
            // 
            this.menuCheckMultipleMonitors.Name = "menuCheckMultipleMonitors";
            resources.ApplyResources(this.menuCheckMultipleMonitors, "menuCheckMultipleMonitors");
            // 
            // menuShowMouseCursor
            // 
            this.menuShowMouseCursor.CheckOnClick = true;
            this.menuShowMouseCursor.Name = "menuShowMouseCursor";
            resources.ApplyResources(this.menuShowMouseCursor, "menuShowMouseCursor");
            this.menuShowMouseCursor.CheckedChanged += new System.EventHandler(this.MenuShowMouseCursorOnCheckedChanged);
            // 
            // menuAlwaysOnTop
            // 
            this.menuAlwaysOnTop.Checked = true;
            this.menuAlwaysOnTop.CheckOnClick = true;
            this.menuAlwaysOnTop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuAlwaysOnTop.Name = "menuAlwaysOnTop";
            resources.ApplyResources(this.menuAlwaysOnTop, "menuAlwaysOnTop");
            this.menuAlwaysOnTop.CheckedChanged += new System.EventHandler(this.MenuAlwaysOnTopOnCheckedChanged);
            // 
            // menuTouchMode
            // 
            this.menuTouchMode.CheckOnClick = true;
            this.menuTouchMode.Name = "menuTouchMode";
            resources.ApplyResources(this.menuTouchMode, "menuTouchMode");
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
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
            resources.ApplyResources(this.menuAbout, "menuAbout");
            // 
            // menuAboutName
            // 
            resources.ApplyResources(this.menuAboutName, "menuAboutName");
            this.menuAboutName.Name = "menuAboutName";
            // 
            // menuAboutVersion
            // 
            resources.ApplyResources(this.menuAboutVersion, "menuAboutVersion");
            this.menuAboutVersion.Name = "menuAboutVersion";
            // 
            // menuAboutCopyright
            // 
            resources.ApplyResources(this.menuAboutCopyright, "menuAboutCopyright");
            this.menuAboutCopyright.Name = "menuAboutCopyright";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // menuAboutHelp
            // 
            this.menuAboutHelp.Name = "menuAboutHelp";
            resources.ApplyResources(this.menuAboutHelp, "menuAboutHelp");
            this.menuAboutHelp.Click += new System.EventHandler(this.MenuAboutUrlItemsOnClick);
            // 
            // menuQuit
            // 
            this.menuQuit.Name = "menuQuit";
            resources.ApplyResources(this.menuQuit, "menuQuit");
            this.menuQuit.Click += new System.EventHandler(this.MenuQuitOnClick);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // closeHelpMenuItem
            // 
            resources.ApplyResources(this.closeHelpMenuItem, "closeHelpMenuItem");
            this.closeHelpMenuItem.Name = "closeHelpMenuItem";
            // 
            // customColorDialog
            // 
            this.customColorDialog.FullOpen = true;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ContextMenuStrip = this.mainContextMenu;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "MainForm";
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

