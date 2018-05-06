namespace prjCsAdminAppRemax
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.statusInfo = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.houseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.findHouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchAgentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.linkToHouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readMessagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.tileUser = new MetroFramework.Controls.MetroTile();
            this.picEmployee = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabPan = new System.Windows.Forms.TableLayoutPanel();
            this.statusInfo.SuspendLayout();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).BeginInit();
            this.tabPan.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusInfo
            // 
            this.statusInfo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusInfo.Location = new System.Drawing.Point(20, 596);
            this.statusInfo.Name = "statusInfo";
            this.statusInfo.Size = new System.Drawing.Size(990, 25);
            this.statusInfo.TabIndex = 1;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(57, 20);
            this.toolStripStatusLabel1.Text = "Version";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.toolStripStatusLabel2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(4, 20);
            // 
            // mainMenu
            // 
            this.mainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMenu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.houseToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.salesToolStripMenuItem2,
            this.messageToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(554, 120);
            this.mainMenu.TabIndex = 3;
            // 
            // houseToolStripMenuItem
            // 
            this.houseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageToolStripMenuItem1,
            this.toolStripMenuItem2,
            this.findHouseToolStripMenuItem});
            this.houseToolStripMenuItem.Image = global::prjCsAdminAppRemax.Properties.Resources.house;
            this.houseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.houseToolStripMenuItem.Name = "houseToolStripMenuItem";
            this.houseToolStripMenuItem.ShowShortcutKeys = false;
            this.houseToolStripMenuItem.Size = new System.Drawing.Size(76, 116);
            this.houseToolStripMenuItem.Text = "&House";
            this.houseToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // manageToolStripMenuItem1
            // 
            this.manageToolStripMenuItem1.Image = global::prjCsAdminAppRemax.Properties.Resources.mng;
            this.manageToolStripMenuItem1.Name = "manageToolStripMenuItem1";
            this.manageToolStripMenuItem1.Size = new System.Drawing.Size(181, 28);
            this.manageToolStripMenuItem1.Text = "Manage";
            this.manageToolStripMenuItem1.Click += new System.EventHandler(this.manageToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(178, 6);
            // 
            // findHouseToolStripMenuItem
            // 
            this.findHouseToolStripMenuItem.Image = global::prjCsAdminAppRemax.Properties.Resources.find;
            this.findHouseToolStripMenuItem.Name = "findHouseToolStripMenuItem";
            this.findHouseToolStripMenuItem.Size = new System.Drawing.Size(181, 28);
            this.findHouseToolStripMenuItem.Text = "Find house";
            this.findHouseToolStripMenuItem.Click += new System.EventHandler(this.findHouseToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageToolStripMenuItem,
            this.toolStripMenuItem3,
            this.salesToolStripMenuItem});
            this.employeeToolStripMenuItem.Image = global::prjCsAdminAppRemax.Properties.Resources.agent;
            this.employeeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(105, 116);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Image = global::prjCsAdminAppRemax.Properties.Resources.mng;
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(181, 28);
            this.manageToolStripMenuItem.Text = "Manage";
            this.manageToolStripMenuItem.Click += new System.EventHandler(this.manageToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(178, 6);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Image = global::prjCsAdminAppRemax.Properties.Resources.find;
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(181, 28);
            this.salesToolStripMenuItem.Text = "Find";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchAgentToolStripMenuItem,
            this.toolStripMenuItem1,
            this.linkToHouseToolStripMenuItem});
            this.clientsToolStripMenuItem.Image = global::prjCsAdminAppRemax.Properties.Resources.clients;
            this.clientsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(81, 116);
            this.clientsToolStripMenuItem.Text = "Clients";
            this.clientsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // searchAgentToolStripMenuItem
            // 
            this.searchAgentToolStripMenuItem.Image = global::prjCsAdminAppRemax.Properties.Resources.mng;
            this.searchAgentToolStripMenuItem.Name = "searchAgentToolStripMenuItem";
            this.searchAgentToolStripMenuItem.Size = new System.Drawing.Size(261, 28);
            this.searchAgentToolStripMenuItem.Text = "Manage";
            this.searchAgentToolStripMenuItem.Click += new System.EventHandler(this.searchAgentToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(258, 6);
            // 
            // linkToHouseToolStripMenuItem
            // 
            this.linkToHouseToolStripMenuItem.Image = global::prjCsAdminAppRemax.Properties.Resources.link;
            this.linkToHouseToolStripMenuItem.Name = "linkToHouseToolStripMenuItem";
            this.linkToHouseToolStripMenuItem.Size = new System.Drawing.Size(261, 28);
            this.linkToHouseToolStripMenuItem.Text = "Link Client to House";
            this.linkToHouseToolStripMenuItem.Click += new System.EventHandler(this.linkToHouseToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem2
            // 
            this.salesToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.salesToolStripMenuItem2.Image = global::prjCsAdminAppRemax.Properties.Resources.sales;
            this.salesToolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.salesToolStripMenuItem2.Name = "salesToolStripMenuItem2";
            this.salesToolStripMenuItem2.Size = new System.Drawing.Size(76, 116);
            this.salesToolStripMenuItem2.Text = "Sales";
            this.salesToolStripMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Image = global::prjCsAdminAppRemax.Properties.Resources.mng;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(181, 28);
            this.viewToolStripMenuItem.Text = "Manage";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // messageToolStripMenuItem
            // 
            this.messageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readMessagesToolStripMenuItem});
            this.messageToolStripMenuItem.Image = global::prjCsAdminAppRemax.Properties.Resources.message;
            this.messageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.messageToolStripMenuItem.Name = "messageToolStripMenuItem";
            this.messageToolStripMenuItem.Size = new System.Drawing.Size(104, 116);
            this.messageToolStripMenuItem.Text = "Messages";
            this.messageToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // readMessagesToolStripMenuItem
            // 
            this.readMessagesToolStripMenuItem.Image = global::prjCsAdminAppRemax.Properties.Resources.readmsg;
            this.readMessagesToolStripMenuItem.Name = "readMessagesToolStripMenuItem";
            this.readMessagesToolStripMenuItem.Size = new System.Drawing.Size(214, 28);
            this.readMessagesToolStripMenuItem.Text = "Read messages";
            this.readMessagesToolStripMenuItem.Click += new System.EventHandler(this.readMessagesToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logOutToolStripMenuItem.Image")));
            this.logOutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(87, 116);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = null;
            this.metroStyleManager.Style = MetroFramework.MetroColorStyle.Red;
            this.metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tileUser
            // 
            this.tileUser.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.tileUser.ActiveControl = null;
            this.tileUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tileUser.CausesValidation = false;
            this.tileUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileUser.Location = new System.Drawing.Point(557, 3);
            this.tileUser.Name = "tileUser";
            this.tileUser.PaintTileCount = false;
            this.tileUser.Size = new System.Drawing.Size(277, 114);
            this.tileUser.Style = MetroFramework.MetroColorStyle.Blue;
            this.tileUser.TabIndex = 6;
            this.tileUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileUser.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileUser.UseSelectable = true;
            // 
            // picEmployee
            // 
            this.picEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picEmployee.Location = new System.Drawing.Point(840, 3);
            this.picEmployee.Name = "picEmployee";
            this.picEmployee.Size = new System.Drawing.Size(147, 114);
            this.picEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEmployee.TabIndex = 8;
            this.picEmployee.TabStop = false;
            this.picEmployee.WaitOnLoad = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tabPan
            // 
            this.tabPan.AutoSize = true;
            this.tabPan.ColumnCount = 3;
            this.tabPan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.21798F));
            this.tabPan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.78202F));
            this.tabPan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tabPan.Controls.Add(this.mainMenu, 0, 0);
            this.tabPan.Controls.Add(this.tileUser, 1, 0);
            this.tabPan.Controls.Add(this.picEmployee, 2, 0);
            this.tabPan.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabPan.Location = new System.Drawing.Point(20, 60);
            this.tabPan.Name = "tabPan";
            this.tabPan.RowCount = 1;
            this.tabPan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tabPan.Size = new System.Drawing.Size(990, 120);
            this.tabPan.TabIndex = 10;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1030, 641);
            this.Controls.Add(this.tabPan);
            this.Controls.Add(this.statusInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Administration’s Application For Remax";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusInfo.ResumeLayout(false);
            this.statusInfo.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).EndInit();
            this.tabPan.ResumeLayout(false);
            this.tabPan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusInfo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private System.Windows.Forms.MenuStrip mainMenu;
        private MetroFramework.Controls.MetroTile tileUser;
        private System.Windows.Forms.PictureBox picEmployee;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchAgentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem houseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.TableLayoutPanel tabPan;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem linkToHouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem findHouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem messageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readMessagesToolStripMenuItem;
    }
}

