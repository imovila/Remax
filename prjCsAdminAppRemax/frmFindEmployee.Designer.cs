namespace prjCsAdminAppRemax
{
    partial class frmFindEmployee
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
            this.cboType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.gridEmployee = new MetroFramework.Controls.MetroGrid();
            this.btnFirst = new System.Windows.Forms.Button();
            this.panEmployee = new MetroFramework.Controls.MetroPanel();
            this.cboLanguage = new System.Windows.Forms.ComboBox();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.cboCityZone = new System.Windows.Forms.ComboBox();
            this.lblCityZone = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblAria = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.tablePan = new System.Windows.Forms.TableLayoutPanel();
            this.titleHouseCount = new MetroFramework.Controls.MetroTile();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureHouse = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployee)).BeginInit();
            this.panEmployee.SuspendLayout();
            this.tablePan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHouse)).BeginInit();
            this.SuspendLayout();
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(513, 92);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(208, 24);
            this.cboType.TabIndex = 5;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(391, 95);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(44, 17);
            this.lblType.TabIndex = 20;
            this.lblType.Text = "Type:";
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
            this.gridEmployee.Location = new System.Drawing.Point(20, 320);
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
            this.gridEmployee.Size = new System.Drawing.Size(910, 343);
            this.gridEmployee.TabIndex = 28;
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.btnFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.ForeColor = System.Drawing.Color.White;
            this.btnFirst.Location = new System.Drawing.Point(701, 285);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(54, 28);
            this.btnFirst.TabIndex = 30;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // panEmployee
            // 
            this.panEmployee.BackColor = System.Drawing.Color.Transparent;
            this.panEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panEmployee.Controls.Add(this.cboLanguage);
            this.panEmployee.Controls.Add(this.cboGender);
            this.panEmployee.Controls.Add(this.btnSearch);
            this.panEmployee.Controls.Add(this.cboType);
            this.panEmployee.Controls.Add(this.lblType);
            this.panEmployee.Controls.Add(this.cboCityZone);
            this.panEmployee.Controls.Add(this.lblCityZone);
            this.panEmployee.Controls.Add(this.lblLanguage);
            this.panEmployee.Controls.Add(this.lblGender);
            this.panEmployee.Controls.Add(this.txtFullName);
            this.panEmployee.Controls.Add(this.lblAria);
            this.panEmployee.Controls.Add(this.txtCode);
            this.panEmployee.Controls.Add(this.lblCode);
            this.panEmployee.HorizontalScrollbarBarColor = true;
            this.panEmployee.HorizontalScrollbarHighlightOnWheel = false;
            this.panEmployee.HorizontalScrollbarSize = 10;
            this.panEmployee.Location = new System.Drawing.Point(20, 111);
            this.panEmployee.Name = "panEmployee";
            this.panEmployee.Size = new System.Drawing.Size(909, 142);
            this.panEmployee.Style = MetroFramework.MetroColorStyle.Orange;
            this.panEmployee.TabIndex = 27;
            this.panEmployee.Theme = MetroFramework.MetroThemeStyle.Light;
            this.panEmployee.UseStyleColors = true;
            this.panEmployee.VerticalScrollbarBarColor = true;
            this.panEmployee.VerticalScrollbarHighlightOnWheel = false;
            this.panEmployee.VerticalScrollbarSize = 10;
            // 
            // cboLanguage
            // 
            this.cboLanguage.FormattingEnabled = true;
            this.cboLanguage.Location = new System.Drawing.Point(513, 15);
            this.cboLanguage.Name = "cboLanguage";
            this.cboLanguage.Size = new System.Drawing.Size(208, 24);
            this.cboLanguage.TabIndex = 3;
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Location = new System.Drawing.Point(148, 92);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(208, 24);
            this.cboGender.TabIndex = 2;
            // 
            // cboCityZone
            // 
            this.cboCityZone.FormattingEnabled = true;
            this.cboCityZone.Location = new System.Drawing.Point(513, 52);
            this.cboCityZone.Name = "cboCityZone";
            this.cboCityZone.Size = new System.Drawing.Size(208, 24);
            this.cboCityZone.TabIndex = 4;
            // 
            // lblCityZone
            // 
            this.lblCityZone.AutoSize = true;
            this.lblCityZone.Location = new System.Drawing.Point(391, 55);
            this.lblCityZone.Name = "lblCityZone";
            this.lblCityZone.Size = new System.Drawing.Size(70, 17);
            this.lblCityZone.TabIndex = 12;
            this.lblCityZone.Text = "City zone:";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(391, 18);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(76, 17);
            this.lblLanguage.TabIndex = 10;
            this.lblLanguage.Text = "Language:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(26, 95);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(60, 17);
            this.lblGender.TabIndex = 8;
            this.lblGender.Text = "Gender:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(148, 52);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(208, 22);
            this.txtFullName.TabIndex = 1;
            // 
            // lblAria
            // 
            this.lblAria.AutoSize = true;
            this.lblAria.Location = new System.Drawing.Point(26, 55);
            this.lblAria.Name = "lblAria";
            this.lblAria.Size = new System.Drawing.Size(75, 17);
            this.lblAria.TabIndex = 6;
            this.lblAria.Text = "Full Name:";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(148, 15);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(208, 22);
            this.txtCode.TabIndex = 0;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(26, 18);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(109, 17);
            this.lblCode.TabIndex = 4;
            this.lblCode.Text = "Employee code:";
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
            this.tablePan.Size = new System.Drawing.Size(910, 49);
            this.tablePan.TabIndex = 29;
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
            this.titleHouseCount.Size = new System.Drawing.Size(801, 43);
            this.titleHouseCount.Style = MetroFramework.MetroColorStyle.Red;
            this.titleHouseCount.TabIndex = 8;
            this.titleHouseCount.Text = "Please specify the search criteria";
            this.titleHouseCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleHouseCount.UseSelectable = true;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(817, 285);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(54, 28);
            this.btnNext.TabIndex = 32;
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
            this.btnLast.Location = new System.Drawing.Point(875, 285);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(54, 28);
            this.btnLast.TabIndex = 33;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(759, 285);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(54, 28);
            this.btnBack.TabIndex = 31;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.GhostWhite;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Image = global::prjCsAdminAppRemax.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(768, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 101);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pictureHouse
            // 
            this.pictureHouse.BackgroundImage = global::prjCsAdminAppRemax.Properties.Resources.remaxlogo;
            this.pictureHouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureHouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureHouse.Location = new System.Drawing.Point(810, 3);
            this.pictureHouse.Name = "pictureHouse";
            this.pictureHouse.Size = new System.Drawing.Size(97, 43);
            this.pictureHouse.TabIndex = 5;
            this.pictureHouse.TabStop = false;
            // 
            // frmFindEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 683);
            this.Controls.Add(this.gridEmployee);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.panEmployee);
            this.Controls.Add(this.tablePan);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnBack);
            this.MinimizeBox = false;
            this.Name = "frmFindEmployee";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Find Employee";
            this.Load += new System.EventHandler(this.frmFindEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployee)).EndInit();
            this.panEmployee.ResumeLayout(false);
            this.panEmployee.PerformLayout();
            this.tablePan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHouse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label lblType;
        private MetroFramework.Controls.MetroGrid gridEmployee;
        private System.Windows.Forms.Button btnFirst;
        private MetroFramework.Controls.MetroPanel panEmployee;
        private System.Windows.Forms.ComboBox cboCityZone;
        private System.Windows.Forms.Label lblCityZone;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblAria;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.PictureBox pictureHouse;
        private System.Windows.Forms.TableLayoutPanel tablePan;
        private MetroFramework.Controls.MetroTile titleHouseCount;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.ComboBox cboLanguage;
    }
}