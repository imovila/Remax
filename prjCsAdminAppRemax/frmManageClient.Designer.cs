namespace DAL
{
    partial class frmManageClient
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.titleClientCount = new MetroFramework.Controls.MetroTile();
            this.tablePan = new System.Windows.Forms.TableLayoutPanel();
            this.gridClient = new MetroFramework.Controls.MetroGrid();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.panClient = new MetroFramework.Controls.MetroPanel();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pictureHouse = new System.Windows.Forms.PictureBox();
            this.tablePan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClient)).BeginInit();
            this.panClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHouse)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::prjCsAdminAppRemax.Properties.Resources.sav;
            this.btnSave.Location = new System.Drawing.Point(651, 221);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 35);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = " Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.btnLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.ForeColor = System.Drawing.Color.White;
            this.btnLast.Location = new System.Drawing.Point(687, 270);
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
            this.btnNext.Location = new System.Drawing.Point(629, 270);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(54, 28);
            this.btnNext.TabIndex = 25;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(571, 270);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(54, 28);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.btnFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.ForeColor = System.Drawing.Color.White;
            this.btnFirst.Location = new System.Drawing.Point(513, 270);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(54, 28);
            this.btnFirst.TabIndex = 23;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // titleClientCount
            // 
            this.titleClientCount.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.titleClientCount.ActiveControl = null;
            this.titleClientCount.BackColor = System.Drawing.Color.Black;
            this.titleClientCount.CausesValidation = false;
            this.titleClientCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleClientCount.Enabled = false;
            this.titleClientCount.Location = new System.Drawing.Point(3, 3);
            this.titleClientCount.Name = "titleClientCount";
            this.titleClientCount.PaintTileCount = false;
            this.titleClientCount.Size = new System.Drawing.Size(633, 43);
            this.titleClientCount.Style = MetroFramework.MetroColorStyle.Red;
            this.titleClientCount.TabIndex = 8;
            this.titleClientCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titleClientCount.UseSelectable = true;
            // 
            // tablePan
            // 
            this.tablePan.ColumnCount = 2;
            this.tablePan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.74062F));
            this.tablePan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.25938F));
            this.tablePan.Controls.Add(this.titleClientCount, 0, 0);
            this.tablePan.Controls.Add(this.pictureHouse, 1, 0);
            this.tablePan.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablePan.Location = new System.Drawing.Point(20, 60);
            this.tablePan.Name = "tablePan";
            this.tablePan.RowCount = 1;
            this.tablePan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePan.Size = new System.Drawing.Size(721, 49);
            this.tablePan.TabIndex = 22;
            // 
            // gridClient
            // 
            this.gridClient.AllowUserToAddRows = false;
            this.gridClient.AllowUserToDeleteRows = false;
            this.gridClient.AllowUserToResizeRows = false;
            this.gridClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridClient.BackgroundColor = System.Drawing.Color.DarkBlue;
            this.gridClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridClient.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.gridClient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridClient.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridClient.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridClient.EnableHeadersVisualStyles = false;
            this.gridClient.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridClient.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridClient.Location = new System.Drawing.Point(20, 306);
            this.gridClient.MultiSelect = false;
            this.gridClient.Name = "gridClient";
            this.gridClient.ReadOnly = true;
            this.gridClient.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridClient.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridClient.RowHeadersVisible = false;
            this.gridClient.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridClient.RowTemplate.Height = 24;
            this.gridClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridClient.Size = new System.Drawing.Size(721, 276);
            this.gridClient.TabIndex = 21;
            this.gridClient.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridClient_CellMouseClick);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(23, 20);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(75, 17);
            this.lblFullName.TabIndex = 4;
            this.lblFullName.Text = "Full Name:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(133, 17);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(208, 22);
            this.txtFullName.TabIndex = 5;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(23, 54);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(53, 17);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Phone:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(133, 51);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(208, 22);
            this.txtPhone.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(399, 17);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 17);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(488, 14);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(208, 22);
            this.txtEmail.TabIndex = 9;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(399, 54);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(44, 17);
            this.lblType.TabIndex = 12;
            this.lblType.Text = "Type:";
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(488, 51);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(208, 24);
            this.cboType.TabIndex = 13;
            // 
            // panClient
            // 
            this.panClient.BackColor = System.Drawing.Color.Transparent;
            this.panClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panClient.Controls.Add(this.cboType);
            this.panClient.Controls.Add(this.lblType);
            this.panClient.Controls.Add(this.txtEmail);
            this.panClient.Controls.Add(this.lblEmail);
            this.panClient.Controls.Add(this.txtPhone);
            this.panClient.Controls.Add(this.lblPhone);
            this.panClient.Controls.Add(this.txtFullName);
            this.panClient.Controls.Add(this.lblFullName);
            this.panClient.HorizontalScrollbarBarColor = true;
            this.panClient.HorizontalScrollbarHighlightOnWheel = false;
            this.panClient.HorizontalScrollbarSize = 10;
            this.panClient.Location = new System.Drawing.Point(20, 110);
            this.panClient.Name = "panClient";
            this.panClient.Size = new System.Drawing.Size(721, 98);
            this.panClient.Style = MetroFramework.MetroColorStyle.Orange;
            this.panClient.TabIndex = 20;
            this.panClient.Theme = MetroFramework.MetroThemeStyle.Light;
            this.panClient.UseStyleColors = true;
            this.panClient.VerticalScrollbarBarColor = true;
            this.panClient.VerticalScrollbarHighlightOnWheel = false;
            this.panClient.VerticalScrollbarSize = 10;
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.ForeColor = System.Drawing.Color.White;
            this.btnModify.Image = global::prjCsAdminAppRemax.Properties.Resources.modify;
            this.btnModify.Location = new System.Drawing.Point(268, 221);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(91, 35);
            this.btnModify.TabIndex = 34;
            this.btnModify.Text = "Modify";
            this.btnModify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::prjCsAdminAppRemax.Properties.Resources.cancel;
            this.btnCancel.Location = new System.Drawing.Point(555, 221);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 35);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::prjCsAdminAppRemax.Properties.Resources.delete;
            this.btnDelete.Location = new System.Drawing.Point(459, 221);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 35);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::prjCsAdminAppRemax.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(364, 221);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 35);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = " Add";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pictureHouse
            // 
            this.pictureHouse.BackgroundImage = global::prjCsAdminAppRemax.Properties.Resources.remaxlogo;
            this.pictureHouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureHouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureHouse.Location = new System.Drawing.Point(642, 3);
            this.pictureHouse.Name = "pictureHouse";
            this.pictureHouse.Size = new System.Drawing.Size(76, 43);
            this.pictureHouse.TabIndex = 5;
            this.pictureHouse.TabStop = false;
            // 
            // frmManageClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 602);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.tablePan);
            this.Controls.Add(this.gridClient);
            this.Controls.Add(this.panClient);
            this.Name = "frmManageClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Manage Client";
            this.Load += new System.EventHandler(this.frmManageClient_Load);
            this.tablePan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridClient)).EndInit();
            this.panClient.ResumeLayout(false);
            this.panClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHouse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox pictureHouse;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnFirst;
        private MetroFramework.Controls.MetroTile titleClientCount;
        private System.Windows.Forms.TableLayoutPanel tablePan;
        private MetroFramework.Controls.MetroGrid gridClient;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cboType;
        private MetroFramework.Controls.MetroPanel panClient;
    }
}