namespace prjCsAdminAppRemax
{
    partial class frmManageHouse
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panHouse = new MetroFramework.Controls.MetroPanel();
            this.txtBathrooms = new System.Windows.Forms.TextBox();
            this.txtRooms = new System.Windows.Forms.TextBox();
            this.cboAgent = new System.Windows.Forms.ComboBox();
            this.txtAgent = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.picAgent = new System.Windows.Forms.PictureBox();
            this.lblAgent = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.cboCityZone = new System.Windows.Forms.ComboBox();
            this.lblCityZone = new System.Windows.Forms.Label();
            this.lblBathrooms = new System.Windows.Forms.Label();
            this.lblRooms = new System.Windows.Forms.Label();
            this.txtAria = new System.Windows.Forms.TextBox();
            this.lblAria = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.picHouse = new System.Windows.Forms.PictureBox();
            this.gridAgentHouses = new MetroFramework.Controls.MetroGrid();
            this.tablePan = new System.Windows.Forms.TableLayoutPanel();
            this.titleHouseCount = new MetroFramework.Controls.MetroTile();
            this.pictureHouse = new System.Windows.Forms.PictureBox();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.openFilePic = new System.Windows.Forms.OpenFileDialog();
            this.panHouse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAgent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAgentHouses)).BeginInit();
            this.tablePan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHouse)).BeginInit();
            this.SuspendLayout();
            // 
            // panHouse
            // 
            this.panHouse.BackColor = System.Drawing.Color.Transparent;
            this.panHouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panHouse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panHouse.Controls.Add(this.txtBathrooms);
            this.panHouse.Controls.Add(this.txtRooms);
            this.panHouse.Controls.Add(this.cboAgent);
            this.panHouse.Controls.Add(this.txtAgent);
            this.panHouse.Controls.Add(this.label13);
            this.panHouse.Controls.Add(this.label12);
            this.panHouse.Controls.Add(this.picAgent);
            this.panHouse.Controls.Add(this.lblAgent);
            this.panHouse.Controls.Add(this.cboStatus);
            this.panHouse.Controls.Add(this.lblStatus);
            this.panHouse.Controls.Add(this.cboType);
            this.panHouse.Controls.Add(this.lblType);
            this.panHouse.Controls.Add(this.txtDescription);
            this.panHouse.Controls.Add(this.lblDescription);
            this.panHouse.Controls.Add(this.lblPrice);
            this.panHouse.Controls.Add(this.txtPrice);
            this.panHouse.Controls.Add(this.txtAddress);
            this.panHouse.Controls.Add(this.lblAddress);
            this.panHouse.Controls.Add(this.cboCityZone);
            this.panHouse.Controls.Add(this.lblCityZone);
            this.panHouse.Controls.Add(this.lblBathrooms);
            this.panHouse.Controls.Add(this.lblRooms);
            this.panHouse.Controls.Add(this.txtAria);
            this.panHouse.Controls.Add(this.lblAria);
            this.panHouse.Controls.Add(this.txtCode);
            this.panHouse.Controls.Add(this.lblCode);
            this.panHouse.Controls.Add(this.btnBrowse);
            this.panHouse.Controls.Add(this.picHouse);
            this.panHouse.HorizontalScrollbarBarColor = true;
            this.panHouse.HorizontalScrollbarHighlightOnWheel = false;
            this.panHouse.HorizontalScrollbarSize = 10;
            this.panHouse.Location = new System.Drawing.Point(20, 110);
            this.panHouse.Name = "panHouse";
            this.panHouse.Size = new System.Drawing.Size(1199, 274);
            this.panHouse.Style = MetroFramework.MetroColorStyle.Orange;
            this.panHouse.TabIndex = 0;
            this.panHouse.Theme = MetroFramework.MetroThemeStyle.Light;
            this.panHouse.UseStyleColors = true;
            this.panHouse.VerticalScrollbarBarColor = true;
            this.panHouse.VerticalScrollbarHighlightOnWheel = false;
            this.panHouse.VerticalScrollbarSize = 10;
            // 
            // txtBathrooms
            // 
            this.txtBathrooms.Location = new System.Drawing.Point(367, 117);
            this.txtBathrooms.Name = "txtBathrooms";
            this.txtBathrooms.Size = new System.Drawing.Size(208, 22);
            this.txtBathrooms.TabIndex = 35;
            // 
            // txtRooms
            // 
            this.txtRooms.Location = new System.Drawing.Point(367, 82);
            this.txtRooms.Name = "txtRooms";
            this.txtRooms.Size = new System.Drawing.Size(208, 22);
            this.txtRooms.TabIndex = 34;
            // 
            // cboAgent
            // 
            this.cboAgent.FormattingEnabled = true;
            this.cboAgent.Location = new System.Drawing.Point(728, 225);
            this.cboAgent.Name = "cboAgent";
            this.cboAgent.Size = new System.Drawing.Size(208, 24);
            this.cboAgent.TabIndex = 31;
            // 
            // txtAgent
            // 
            this.txtAgent.Enabled = false;
            this.txtAgent.Location = new System.Drawing.Point(728, 226);
            this.txtAgent.Name = "txtAgent";
            this.txtAgent.Size = new System.Drawing.Size(208, 22);
            this.txtAgent.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1057, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "Agent";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(90, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = "House";
            // 
            // picAgent
            // 
            this.picAgent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAgent.Location = new System.Drawing.Point(978, 28);
            this.picAgent.Name = "picAgent";
            this.picAgent.Size = new System.Drawing.Size(202, 191);
            this.picAgent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAgent.TabIndex = 26;
            this.picAgent.TabStop = false;
            // 
            // lblAgent
            // 
            this.lblAgent.AutoSize = true;
            this.lblAgent.Location = new System.Drawing.Point(617, 229);
            this.lblAgent.Name = "lblAgent";
            this.lblAgent.Size = new System.Drawing.Size(49, 17);
            this.lblAgent.TabIndex = 24;
            this.lblAgent.Text = "Agent:";
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(728, 188);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(208, 24);
            this.cboStatus.TabIndex = 23;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(618, 191);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 17);
            this.lblStatus.TabIndex = 22;
            this.lblStatus.Text = "Status:";
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(727, 151);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(208, 24);
            this.cboType.TabIndex = 21;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(617, 154);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(44, 17);
            this.lblType.TabIndex = 20;
            this.lblType.Text = "Type:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(727, 51);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(208, 86);
            this.txtDescription.TabIndex = 19;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(617, 51);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(83, 17);
            this.lblDescription.TabIndex = 18;
            this.lblDescription.Text = "Description:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(617, 20);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(86, 17);
            this.lblPrice.TabIndex = 17;
            this.lblPrice.Text = "Price (CAD):";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(726, 17);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(208, 22);
            this.txtPrice.TabIndex = 16;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(367, 195);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddress.Size = new System.Drawing.Size(208, 53);
            this.txtAddress.TabIndex = 15;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(250, 195);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(64, 17);
            this.lblAddress.TabIndex = 14;
            this.lblAddress.Text = "Address:";
            // 
            // cboCityZone
            // 
            this.cboCityZone.FormattingEnabled = true;
            this.cboCityZone.Location = new System.Drawing.Point(367, 154);
            this.cboCityZone.Name = "cboCityZone";
            this.cboCityZone.Size = new System.Drawing.Size(208, 24);
            this.cboCityZone.TabIndex = 13;
            // 
            // lblCityZone
            // 
            this.lblCityZone.AutoSize = true;
            this.lblCityZone.Location = new System.Drawing.Point(250, 157);
            this.lblCityZone.Name = "lblCityZone";
            this.lblCityZone.Size = new System.Drawing.Size(70, 17);
            this.lblCityZone.TabIndex = 12;
            this.lblCityZone.Text = "City zone:";
            // 
            // lblBathrooms
            // 
            this.lblBathrooms.AutoSize = true;
            this.lblBathrooms.Location = new System.Drawing.Point(250, 120);
            this.lblBathrooms.Name = "lblBathrooms";
            this.lblBathrooms.Size = new System.Drawing.Size(80, 17);
            this.lblBathrooms.TabIndex = 10;
            this.lblBathrooms.Text = "Bathrooms:";
            // 
            // lblRooms
            // 
            this.lblRooms.AutoSize = true;
            this.lblRooms.Location = new System.Drawing.Point(250, 85);
            this.lblRooms.Name = "lblRooms";
            this.lblRooms.Size = new System.Drawing.Size(56, 17);
            this.lblRooms.TabIndex = 8;
            this.lblRooms.Text = "Rooms:";
            // 
            // txtAria
            // 
            this.txtAria.Location = new System.Drawing.Point(367, 48);
            this.txtAria.Name = "txtAria";
            this.txtAria.Size = new System.Drawing.Size(208, 22);
            this.txtAria.TabIndex = 7;
            // 
            // lblAria
            // 
            this.lblAria.AutoSize = true;
            this.lblAria.Location = new System.Drawing.Point(250, 51);
            this.lblAria.Name = "lblAria";
            this.lblAria.Size = new System.Drawing.Size(70, 17);
            this.lblAria.TabIndex = 6;
            this.lblAria.Text = "Aria (m2):";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(367, 17);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(208, 22);
            this.txtCode.TabIndex = 5;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(250, 20);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(88, 17);
            this.lblCode.TabIndex = 4;
            this.lblCode.Text = "House code:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBrowse.Location = new System.Drawing.Point(57, 226);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(116, 36);
            this.btnBrowse.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseSelectable = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // picHouse
            // 
            this.picHouse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHouse.Location = new System.Drawing.Point(18, 28);
            this.picHouse.Name = "picHouse";
            this.picHouse.Size = new System.Drawing.Size(202, 191);
            this.picHouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHouse.TabIndex = 2;
            this.picHouse.TabStop = false;
            // 
            // gridAgentHouses
            // 
            this.gridAgentHouses.AllowUserToAddRows = false;
            this.gridAgentHouses.AllowUserToDeleteRows = false;
            this.gridAgentHouses.AllowUserToResizeRows = false;
            this.gridAgentHouses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridAgentHouses.BackgroundColor = System.Drawing.Color.DarkBlue;
            this.gridAgentHouses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridAgentHouses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.gridAgentHouses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAgentHouses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridAgentHouses.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridAgentHouses.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridAgentHouses.EnableHeadersVisualStyles = false;
            this.gridAgentHouses.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridAgentHouses.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridAgentHouses.Location = new System.Drawing.Point(20, 478);
            this.gridAgentHouses.MultiSelect = false;
            this.gridAgentHouses.Name = "gridAgentHouses";
            this.gridAgentHouses.ReadOnly = true;
            this.gridAgentHouses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAgentHouses.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridAgentHouses.RowHeadersVisible = false;
            this.gridAgentHouses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridAgentHouses.RowTemplate.Height = 24;
            this.gridAgentHouses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAgentHouses.Size = new System.Drawing.Size(1199, 276);
            this.gridAgentHouses.TabIndex = 1;
            this.gridAgentHouses.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridAgentHouses_CellMouseClick);
            // 
            // tablePan
            // 
            this.tablePan.ColumnCount = 2;
            this.tablePan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.74062F));
            this.tablePan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.25938F));
            this.tablePan.Controls.Add(this.titleHouseCount, 0, 0);
            this.tablePan.Controls.Add(this.pictureHouse, 1, 0);
            this.tablePan.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablePan.Location = new System.Drawing.Point(20, 60);
            this.tablePan.Name = "tablePan";
            this.tablePan.RowCount = 1;
            this.tablePan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePan.Size = new System.Drawing.Size(1199, 49);
            this.tablePan.TabIndex = 3;
            // 
            // titleHouseCount
            // 
            this.titleHouseCount.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.titleHouseCount.ActiveControl = null;
            this.titleHouseCount.BackColor = System.Drawing.Color.Black;
            this.titleHouseCount.CausesValidation = false;
            this.titleHouseCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleHouseCount.Enabled = false;
            this.titleHouseCount.Location = new System.Drawing.Point(3, 3);
            this.titleHouseCount.Name = "titleHouseCount";
            this.titleHouseCount.PaintTileCount = false;
            this.titleHouseCount.Size = new System.Drawing.Size(1058, 43);
            this.titleHouseCount.Style = MetroFramework.MetroColorStyle.Red;
            this.titleHouseCount.TabIndex = 8;
            this.titleHouseCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titleHouseCount.UseSelectable = true;
            // 
            // pictureHouse
            // 
            this.pictureHouse.BackgroundImage = global::prjCsAdminAppRemax.Properties.Resources.remaxlogo;
            this.pictureHouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureHouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureHouse.Location = new System.Drawing.Point(1067, 3);
            this.pictureHouse.Name = "pictureHouse";
            this.pictureHouse.Size = new System.Drawing.Size(129, 43);
            this.pictureHouse.TabIndex = 5;
            this.pictureHouse.TabStop = false;
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.btnFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.ForeColor = System.Drawing.Color.White;
            this.btnFirst.Location = new System.Drawing.Point(989, 444);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(54, 28);
            this.btnFirst.TabIndex = 8;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(1047, 444);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(54, 28);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(1105, 444);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(54, 28);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.btnLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.ForeColor = System.Drawing.Color.White;
            this.btnLast.Location = new System.Drawing.Point(1163, 444);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(54, 28);
            this.btnLast.TabIndex = 11;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // txtFind
            // 
            this.txtFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.Location = new System.Drawing.Point(117, 401);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(335, 30);
            this.txtFind.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(23, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 34);
            this.label1.TabIndex = 13;
            this.label1.Text = "Find house\r\nby CODE:";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.GhostWhite;
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.Image = global::prjCsAdminAppRemax.Properties.Resources.find_transp;
            this.btnFind.Location = new System.Drawing.Point(458, 399);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(76, 35);
            this.btnFind.TabIndex = 14;
            this.btnFind.Text = "Find";
            this.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::prjCsAdminAppRemax.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(841, 395);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 35);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = " Add";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::prjCsAdminAppRemax.Properties.Resources.delete;
            this.btnDelete.Location = new System.Drawing.Point(936, 395);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 35);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::prjCsAdminAppRemax.Properties.Resources.cancel;
            this.btnCancel.Location = new System.Drawing.Point(1032, 395);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 35);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::prjCsAdminAppRemax.Properties.Resources.sav;
            this.btnSave.Location = new System.Drawing.Point(1128, 395);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 35);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = " Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.ForeColor = System.Drawing.Color.White;
            this.btnModify.Image = global::prjCsAdminAppRemax.Properties.Resources.modify;
            this.btnModify.Location = new System.Drawing.Point(745, 395);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(91, 35);
            this.btnModify.TabIndex = 19;
            this.btnModify.Text = "Modify";
            this.btnModify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // openFilePic
            // 
            this.openFilePic.DefaultExt = "*.jpeg";
            this.openFilePic.Filter = "PNG|*.png|JPEG|*.jpeg|JPG|*.jpg";
            this.openFilePic.Title = "Set house picture";
            // 
            // frmManageHouse
            // 
            this.AcceptButton = this.btnFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1239, 774);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.tablePan);
            this.Controls.Add(this.gridAgentHouses);
            this.Controls.Add(this.panHouse);
            this.MaximizeBox = false;
            this.Name = "frmManageHouse";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Manage House";
            this.Load += new System.EventHandler(this.frmFindHouse_Load);
            this.panHouse.ResumeLayout(false);
            this.panHouse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAgent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAgentHouses)).EndInit();
            this.tablePan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panHouse;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private System.Windows.Forms.PictureBox picHouse;
        private System.Windows.Forms.TextBox txtAria;
        private System.Windows.Forms.Label lblAria;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.ComboBox cboCityZone;
        private System.Windows.Forms.Label lblCityZone;
        private System.Windows.Forms.Label lblBathrooms;
        private System.Windows.Forms.Label lblRooms;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox picAgent;
        private System.Windows.Forms.Label lblAgent;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label13;
        private MetroFramework.Controls.MetroGrid gridAgentHouses;
        private System.Windows.Forms.TableLayoutPanel tablePan;
        private System.Windows.Forms.PictureBox pictureHouse;
        private MetroFramework.Controls.MetroTile titleHouseCount;
        private System.Windows.Forms.TextBox txtAgent;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.OpenFileDialog openFilePic;
        private System.Windows.Forms.ComboBox cboAgent;
        private System.Windows.Forms.TextBox txtRooms;
        private System.Windows.Forms.TextBox txtBathrooms;
    }
}