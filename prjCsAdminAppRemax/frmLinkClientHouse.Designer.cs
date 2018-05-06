namespace prjCsAdminAppRemax
{
    partial class frmLinkClientHouse
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
            this.panLink = new MetroFramework.Controls.MetroPanel();
            this.cboClients = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.tablePan = new System.Windows.Forms.TableLayoutPanel();
            this.titleHouseToLink = new MetroFramework.Controls.MetroTile();
            this.gridHousesToClient = new MetroFramework.Controls.MetroGrid();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.metroTile = new MetroFramework.Controls.MetroTile();
            this.pictureHouse = new System.Windows.Forms.PictureBox();
            this.btnJoin = new System.Windows.Forms.Button();
            this.panLink.SuspendLayout();
            this.tablePan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHousesToClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHouse)).BeginInit();
            this.SuspendLayout();
            // 
            // panLink
            // 
            this.panLink.BackColor = System.Drawing.Color.Transparent;
            this.panLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panLink.Controls.Add(this.cboClients);
            this.panLink.Controls.Add(this.lblType);
            this.panLink.Controls.Add(this.txtEmail);
            this.panLink.Controls.Add(this.lblEmail);
            this.panLink.Controls.Add(this.txtPhone);
            this.panLink.Controls.Add(this.lblPhone);
            this.panLink.Controls.Add(this.txtType);
            this.panLink.Controls.Add(this.lblFullName);
            this.panLink.HorizontalScrollbarBarColor = true;
            this.panLink.HorizontalScrollbarHighlightOnWheel = false;
            this.panLink.HorizontalScrollbarSize = 10;
            this.panLink.Location = new System.Drawing.Point(20, 112);
            this.panLink.Name = "panLink";
            this.panLink.Size = new System.Drawing.Size(760, 98);
            this.panLink.Style = MetroFramework.MetroColorStyle.Orange;
            this.panLink.TabIndex = 35;
            this.panLink.Theme = MetroFramework.MetroThemeStyle.Light;
            this.panLink.UseStyleColors = true;
            this.panLink.VerticalScrollbarBarColor = true;
            this.panLink.VerticalScrollbarHighlightOnWheel = false;
            this.panLink.VerticalScrollbarSize = 10;
            // 
            // cboClients
            // 
            this.cboClients.FormattingEnabled = true;
            this.cboClients.Location = new System.Drawing.Point(133, 14);
            this.cboClients.Name = "cboClients";
            this.cboClients.Size = new System.Drawing.Size(208, 24);
            this.cboClients.TabIndex = 13;
            this.cboClients.SelectedIndexChanged += new System.EventHandler(this.cboClients_SelectedIndexChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(424, 54);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(44, 17);
            this.lblType.TabIndex = 12;
            this.lblType.Text = "Type:";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(513, 14);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(208, 22);
            this.txtEmail.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(424, 17);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 17);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";
            // 
            // txtPhone
            // 
            this.txtPhone.Enabled = false;
            this.txtPhone.Location = new System.Drawing.Point(133, 51);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(208, 22);
            this.txtPhone.TabIndex = 7;
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
            // txtType
            // 
            this.txtType.Enabled = false;
            this.txtType.Location = new System.Drawing.Point(513, 54);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(208, 22);
            this.txtType.TabIndex = 5;
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
            // tablePan
            // 
            this.tablePan.ColumnCount = 2;
            this.tablePan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.74062F));
            this.tablePan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.25938F));
            this.tablePan.Controls.Add(this.titleHouseToLink, 0, 0);
            this.tablePan.Controls.Add(this.pictureHouse, 1, 0);
            this.tablePan.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablePan.Location = new System.Drawing.Point(20, 60);
            this.tablePan.Name = "tablePan";
            this.tablePan.RowCount = 1;
            this.tablePan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePan.Size = new System.Drawing.Size(760, 49);
            this.tablePan.TabIndex = 37;
            // 
            // titleHouseToLink
            // 
            this.titleHouseToLink.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.titleHouseToLink.ActiveControl = null;
            this.titleHouseToLink.BackColor = System.Drawing.Color.Black;
            this.titleHouseToLink.CausesValidation = false;
            this.titleHouseToLink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleHouseToLink.Enabled = false;
            this.titleHouseToLink.Location = new System.Drawing.Point(3, 3);
            this.titleHouseToLink.Name = "titleHouseToLink";
            this.titleHouseToLink.PaintTileCount = false;
            this.titleHouseToLink.Size = new System.Drawing.Size(668, 43);
            this.titleHouseToLink.Style = MetroFramework.MetroColorStyle.Red;
            this.titleHouseToLink.TabIndex = 8;
            this.titleHouseToLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titleHouseToLink.UseSelectable = true;
            // 
            // gridHousesToClient
            // 
            this.gridHousesToClient.AllowUserToAddRows = false;
            this.gridHousesToClient.AllowUserToDeleteRows = false;
            this.gridHousesToClient.AllowUserToResizeRows = false;
            this.gridHousesToClient.BackgroundColor = System.Drawing.Color.DarkBlue;
            this.gridHousesToClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridHousesToClient.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.gridHousesToClient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridHousesToClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridHousesToClient.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridHousesToClient.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridHousesToClient.EnableHeadersVisualStyles = false;
            this.gridHousesToClient.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridHousesToClient.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridHousesToClient.Location = new System.Drawing.Point(20, 306);
            this.gridHousesToClient.MultiSelect = false;
            this.gridHousesToClient.Name = "gridHousesToClient";
            this.gridHousesToClient.ReadOnly = true;
            this.gridHousesToClient.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridHousesToClient.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridHousesToClient.RowHeadersVisible = false;
            this.gridHousesToClient.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridHousesToClient.RowTemplate.Height = 24;
            this.gridHousesToClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridHousesToClient.Size = new System.Drawing.Size(760, 276);
            this.gridHousesToClient.TabIndex = 36;
            this.gridHousesToClient.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridHousesToClient_CellMouseClick);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.btnLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.ForeColor = System.Drawing.Color.White;
            this.btnLast.Location = new System.Drawing.Point(725, 271);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(54, 28);
            this.btnLast.TabIndex = 41;
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
            this.btnNext.Location = new System.Drawing.Point(667, 271);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(54, 28);
            this.btnNext.TabIndex = 40;
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
            this.btnBack.Location = new System.Drawing.Point(609, 271);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(54, 28);
            this.btnBack.TabIndex = 39;
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
            this.btnFirst.Location = new System.Drawing.Point(551, 271);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(54, 28);
            this.btnFirst.TabIndex = 38;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // metroTile
            // 
            this.metroTile.ActiveControl = null;
            this.metroTile.BackColor = System.Drawing.Color.Tomato;
            this.metroTile.Enabled = false;
            this.metroTile.ForeColor = System.Drawing.Color.Navy;
            this.metroTile.Location = new System.Drawing.Point(21, 218);
            this.metroTile.Name = "metroTile";
            this.metroTile.PaintTileCount = false;
            this.metroTile.Size = new System.Drawing.Size(341, 82);
            this.metroTile.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile.TabIndex = 46;
            this.metroTile.Text = "The list of houses that need \r\nto be joined to the client:";
            this.metroTile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile.UseCustomForeColor = true;
            this.metroTile.UseSelectable = true;
            this.metroTile.UseStyleColors = true;
            // 
            // pictureHouse
            // 
            this.pictureHouse.BackgroundImage = global::prjCsAdminAppRemax.Properties.Resources.remaxlogo;
            this.pictureHouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureHouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureHouse.Location = new System.Drawing.Point(677, 3);
            this.pictureHouse.Name = "pictureHouse";
            this.pictureHouse.Size = new System.Drawing.Size(80, 43);
            this.pictureHouse.TabIndex = 5;
            this.pictureHouse.TabStop = false;
            // 
            // btnJoin
            // 
            this.btnJoin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnJoin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoin.ForeColor = System.Drawing.Color.White;
            this.btnJoin.Image = global::prjCsAdminAppRemax.Properties.Resources.link_transp;
            this.btnJoin.Location = new System.Drawing.Point(689, 222);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(91, 35);
            this.btnJoin.TabIndex = 45;
            this.btnJoin.Text = "Join";
            this.btnJoin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnJoin.UseVisualStyleBackColor = false;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // frmLinkClientHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 602);
            this.Controls.Add(this.metroTile);
            this.Controls.Add(this.panLink);
            this.Controls.Add(this.tablePan);
            this.Controls.Add(this.gridHousesToClient);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnJoin);
            this.MaximizeBox = false;
            this.Name = "frmLinkClientHouse";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Join Client to House";
            this.Load += new System.EventHandler(this.frmLinkClientHouse_Load);
            this.panLink.ResumeLayout(false);
            this.panLink.PerformLayout();
            this.tablePan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridHousesToClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHouse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panLink;
        private System.Windows.Forms.ComboBox cboClients;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TableLayoutPanel tablePan;
        private MetroFramework.Controls.MetroTile titleHouseToLink;
        private System.Windows.Forms.PictureBox pictureHouse;
        private MetroFramework.Controls.MetroGrid gridHousesToClient;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnJoin;
        private MetroFramework.Controls.MetroTile metroTile;
    }
}