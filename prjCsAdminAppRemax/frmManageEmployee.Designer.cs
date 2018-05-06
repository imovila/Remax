namespace prjCsAdminAppRemax
{
    partial class frmManageEmployee
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPicEmployee = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cboCityZone = new System.Windows.Forms.ComboBox();
            this.lblCityZone = new System.Windows.Forms.Label();
            this.lblLang = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.openFilePic = new System.Windows.Forms.OpenFileDialog();
            this.lblGender = new System.Windows.Forms.Label();
            this.titleHouseCount = new MetroFramework.Controls.MetroTile();
            this.tablePan = new System.Windows.Forms.TableLayoutPanel();
            this.pictureHouse = new System.Windows.Forms.PictureBox();
            this.gridEmployee = new MetroFramework.Controls.MetroGrid();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.picEmployee = new System.Windows.Forms.PictureBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.panEmpoyee = new MetroFramework.Controls.MetroPanel();
            this.cboLang = new System.Windows.Forms.ComboBox();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.tablePan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).BeginInit();
            this.panEmpoyee.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::prjCsAdminAppRemax.Properties.Resources.delete;
            this.btnDelete.Location = new System.Drawing.Point(710, 395);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 35);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(747, 60);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(208, 22);
            this.txtPassword.TabIndex = 7;
            // 
            // lblPicEmployee
            // 
            this.lblPicEmployee.AutoSize = true;
            this.lblPicEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPicEmployee.Location = new System.Drawing.Point(75, 8);
            this.lblPicEmployee.Name = "lblPicEmployee";
            this.lblPicEmployee.Size = new System.Drawing.Size(78, 17);
            this.lblPicEmployee.TabIndex = 28;
            this.lblPicEmployee.Text = "Employee";
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(381, 200);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(208, 24);
            this.cboType.TabIndex = 5;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(250, 200);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(44, 17);
            this.lblType.TabIndex = 20;
            this.lblType.Text = "Type:";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.GhostWhite;
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.Image = global::prjCsAdminAppRemax.Properties.Resources.find_transp;
            this.btnFind.Location = new System.Drawing.Point(329, 396);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(76, 35);
            this.btnFind.TabIndex = 29;
            this.btnFind.Text = "Find";
            this.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(23, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 34);
            this.label1.TabIndex = 28;
            this.label1.Text = "Find employee \r\nby CODE:";
            // 
            // txtFind
            // 
            this.txtFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.Location = new System.Drawing.Point(147, 400);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(168, 28);
            this.txtFind.TabIndex = 27;
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.btnLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.ForeColor = System.Drawing.Color.White;
            this.btnLast.Location = new System.Drawing.Point(937, 444);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(54, 28);
            this.btnLast.TabIndex = 26;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(879, 444);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(54, 28);
            this.btnNext.TabIndex = 25;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(638, 63);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 17);
            this.lblPassword.TabIndex = 18;
            this.lblPassword.Text = "Password:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(638, 29);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(81, 17);
            this.lblUserName.TabIndex = 17;
            this.lblUserName.Text = "User name:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(747, 26);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(208, 22);
            this.txtUserName.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::prjCsAdminAppRemax.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(615, 395);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 35);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = " Add";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.btnFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.ForeColor = System.Drawing.Color.White;
            this.btnFirst.Location = new System.Drawing.Point(763, 444);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(54, 28);
            this.btnFirst.TabIndex = 23;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::prjCsAdminAppRemax.Properties.Resources.sav;
            this.btnSave.Location = new System.Drawing.Point(902, 395);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 35);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = " Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cboCityZone
            // 
            this.cboCityZone.FormattingEnabled = true;
            this.cboCityZone.Location = new System.Drawing.Point(381, 163);
            this.cboCityZone.Name = "cboCityZone";
            this.cboCityZone.Size = new System.Drawing.Size(208, 24);
            this.cboCityZone.TabIndex = 4;
            // 
            // lblCityZone
            // 
            this.lblCityZone.AutoSize = true;
            this.lblCityZone.Location = new System.Drawing.Point(250, 163);
            this.lblCityZone.Name = "lblCityZone";
            this.lblCityZone.Size = new System.Drawing.Size(70, 17);
            this.lblCityZone.TabIndex = 12;
            this.lblCityZone.Text = "City zone:";
            // 
            // lblLang
            // 
            this.lblLang.AutoSize = true;
            this.lblLang.Location = new System.Drawing.Point(250, 129);
            this.lblLang.Name = "lblLang";
            this.lblLang.Size = new System.Drawing.Size(76, 17);
            this.lblLang.TabIndex = 10;
            this.lblLang.Text = "Language:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::prjCsAdminAppRemax.Properties.Resources.cancel;
            this.btnCancel.Location = new System.Drawing.Point(806, 395);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 35);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(821, 444);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(54, 28);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // openFilePic
            // 
            this.openFilePic.DefaultExt = "*.jpeg";
            this.openFilePic.Filter = "PNG|*.png|JPEG|*.jpeg|JPG|*.jpg";
            this.openFilePic.Title = "Set house picture";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(250, 94);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(60, 17);
            this.lblGender.TabIndex = 8;
            this.lblGender.Text = "Gender:";
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
            this.titleHouseCount.Size = new System.Drawing.Size(857, 43);
            this.titleHouseCount.Style = MetroFramework.MetroColorStyle.Red;
            this.titleHouseCount.TabIndex = 8;
            this.titleHouseCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titleHouseCount.UseSelectable = true;
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
            this.tablePan.Size = new System.Drawing.Size(973, 49);
            this.tablePan.TabIndex = 22;
            // 
            // pictureHouse
            // 
            this.pictureHouse.BackgroundImage = global::prjCsAdminAppRemax.Properties.Resources.remaxlogo;
            this.pictureHouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureHouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureHouse.Location = new System.Drawing.Point(866, 3);
            this.pictureHouse.Name = "pictureHouse";
            this.pictureHouse.Size = new System.Drawing.Size(104, 43);
            this.pictureHouse.TabIndex = 5;
            this.pictureHouse.TabStop = false;
            // 
            // gridEmployee
            // 
            this.gridEmployee.AllowUserToAddRows = false;
            this.gridEmployee.AllowUserToDeleteRows = false;
            this.gridEmployee.AllowUserToResizeRows = false;
            this.gridEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridEmployee.BackgroundColor = System.Drawing.Color.DarkBlue;
            this.gridEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridEmployee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.gridEmployee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridEmployee.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridEmployee.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridEmployee.EnableHeadersVisualStyles = false;
            this.gridEmployee.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridEmployee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridEmployee.Location = new System.Drawing.Point(20, 478);
            this.gridEmployee.MultiSelect = false;
            this.gridEmployee.Name = "gridEmployee";
            this.gridEmployee.ReadOnly = true;
            this.gridEmployee.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridEmployee.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridEmployee.RowHeadersVisible = false;
            this.gridEmployee.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridEmployee.RowTemplate.Height = 24;
            this.gridEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEmployee.Size = new System.Drawing.Size(973, 276);
            this.gridEmployee.TabIndex = 21;
            this.gridEmployee.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridEmployee_CellMouseClick);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(381, 57);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(208, 22);
            this.txtFullName.TabIndex = 1;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(250, 60);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(73, 17);
            this.lblFullName.TabIndex = 6;
            this.lblFullName.Text = "Full name:";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(381, 26);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(208, 22);
            this.txtCode.TabIndex = 0;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(250, 29);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(109, 17);
            this.lblCode.TabIndex = 4;
            this.lblCode.Text = "Employee code:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBrowse.Location = new System.Drawing.Point(57, 226);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(116, 36);
            this.btnBrowse.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseSelectable = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // picEmployee
            // 
            this.picEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picEmployee.Location = new System.Drawing.Point(18, 28);
            this.picEmployee.Name = "picEmployee";
            this.picEmployee.Size = new System.Drawing.Size(202, 191);
            this.picEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEmployee.TabIndex = 2;
            this.picEmployee.TabStop = false;
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.ForeColor = System.Drawing.Color.White;
            this.btnModify.Image = global::prjCsAdminAppRemax.Properties.Resources.modify;
            this.btnModify.Location = new System.Drawing.Point(519, 395);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(91, 35);
            this.btnModify.TabIndex = 34;
            this.btnModify.Text = "Modify";
            this.btnModify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // panEmpoyee
            // 
            this.panEmpoyee.BackColor = System.Drawing.Color.Transparent;
            this.panEmpoyee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panEmpoyee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panEmpoyee.Controls.Add(this.cboLang);
            this.panEmpoyee.Controls.Add(this.cboGender);
            this.panEmpoyee.Controls.Add(this.txtPassword);
            this.panEmpoyee.Controls.Add(this.lblPicEmployee);
            this.panEmpoyee.Controls.Add(this.cboType);
            this.panEmpoyee.Controls.Add(this.lblType);
            this.panEmpoyee.Controls.Add(this.lblPassword);
            this.panEmpoyee.Controls.Add(this.lblUserName);
            this.panEmpoyee.Controls.Add(this.txtUserName);
            this.panEmpoyee.Controls.Add(this.cboCityZone);
            this.panEmpoyee.Controls.Add(this.lblCityZone);
            this.panEmpoyee.Controls.Add(this.lblLang);
            this.panEmpoyee.Controls.Add(this.lblGender);
            this.panEmpoyee.Controls.Add(this.txtFullName);
            this.panEmpoyee.Controls.Add(this.lblFullName);
            this.panEmpoyee.Controls.Add(this.txtCode);
            this.panEmpoyee.Controls.Add(this.lblCode);
            this.panEmpoyee.Controls.Add(this.btnBrowse);
            this.panEmpoyee.Controls.Add(this.picEmployee);
            this.panEmpoyee.HorizontalScrollbarBarColor = true;
            this.panEmpoyee.HorizontalScrollbarHighlightOnWheel = false;
            this.panEmpoyee.HorizontalScrollbarSize = 10;
            this.panEmpoyee.Location = new System.Drawing.Point(20, 111);
            this.panEmpoyee.Name = "panEmpoyee";
            this.panEmpoyee.Size = new System.Drawing.Size(972, 274);
            this.panEmpoyee.Style = MetroFramework.MetroColorStyle.Orange;
            this.panEmpoyee.TabIndex = 20;
            this.panEmpoyee.Theme = MetroFramework.MetroThemeStyle.Light;
            this.panEmpoyee.UseStyleColors = true;
            this.panEmpoyee.VerticalScrollbarBarColor = true;
            this.panEmpoyee.VerticalScrollbarHighlightOnWheel = false;
            this.panEmpoyee.VerticalScrollbarSize = 10;
            // 
            // cboLang
            // 
            this.cboLang.FormattingEnabled = true;
            this.cboLang.Location = new System.Drawing.Point(381, 126);
            this.cboLang.Name = "cboLang";
            this.cboLang.Size = new System.Drawing.Size(208, 24);
            this.cboLang.TabIndex = 3;
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Location = new System.Drawing.Point(381, 91);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(208, 24);
            this.cboGender.TabIndex = 2;
            // 
            // frmManageEmployee
            // 
            this.AcceptButton = this.btnFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 774);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tablePan);
            this.Controls.Add(this.gridEmployee);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.panEmpoyee);
            this.MinimizeBox = false;
            this.Name = "frmManageEmployee";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Manage Employee";
            this.Load += new System.EventHandler(this.frmManageEmployee_Load);
            this.tablePan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).EndInit();
            this.panEmpoyee.ResumeLayout(false);
            this.panEmpoyee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPicEmployee;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cboCityZone;
        private System.Windows.Forms.Label lblCityZone;
        private System.Windows.Forms.Label lblLang;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.OpenFileDialog openFilePic;
        private System.Windows.Forms.Label lblGender;
        private MetroFramework.Controls.MetroTile titleHouseCount;
        private System.Windows.Forms.TableLayoutPanel tablePan;
        private System.Windows.Forms.PictureBox pictureHouse;
        private MetroFramework.Controls.MetroGrid gridEmployee;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private System.Windows.Forms.PictureBox picEmployee;
        private System.Windows.Forms.Button btnModify;
        private MetroFramework.Controls.MetroPanel panEmpoyee;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.ComboBox cboLang;
    }
}