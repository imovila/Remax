namespace prjCsAdminAppRemax
{
    partial class frmFindHouse
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
            this.lblAgent = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.cboCityZone = new System.Windows.Forms.ComboBox();
            this.lblCityZone = new System.Windows.Forms.Label();
            this.txtBathrooms = new System.Windows.Forms.TextBox();
            this.lblBathrooms = new System.Windows.Forms.Label();
            this.txtRooms = new System.Windows.Forms.TextBox();
            this.lblRooms = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtAria = new System.Windows.Forms.TextBox();
            this.titleHouseCount = new MetroFramework.Controls.MetroTile();
            this.tablePan = new System.Windows.Forms.TableLayoutPanel();
            this.pictureHouse = new System.Windows.Forms.PictureBox();
            this.gridAgentHouses = new MetroFramework.Controls.MetroGrid();
            this.lblAria = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.btnFirst = new System.Windows.Forms.Button();
            this.panHouse = new MetroFramework.Controls.MetroPanel();
            this.cboAgent = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPriceTo = new System.Windows.Forms.TextBox();
            this.txtPriceFrom = new System.Windows.Forms.TextBox();
            this.tablePan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAgentHouses)).BeginInit();
            this.panHouse.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAgent
            // 
            this.lblAgent.AutoSize = true;
            this.lblAgent.Location = new System.Drawing.Point(381, 126);
            this.lblAgent.Name = "lblAgent";
            this.lblAgent.Size = new System.Drawing.Size(49, 17);
            this.lblAgent.TabIndex = 24;
            this.lblAgent.Text = "Agent:";
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(524, 85);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(208, 24);
            this.cboStatus.TabIndex = 23;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(382, 88);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 17);
            this.lblStatus.TabIndex = 22;
            this.lblStatus.Text = "Status:";
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(523, 48);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(208, 24);
            this.cboType.TabIndex = 21;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(381, 51);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(44, 17);
            this.lblType.TabIndex = 20;
            this.lblType.Text = "Type:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.GhostWhite;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Image = global::prjCsAdminAppRemax.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(768, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 120);
            this.btnSearch.TabIndex = 29;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.btnLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.ForeColor = System.Drawing.Color.White;
            this.btnLast.Location = new System.Drawing.Point(874, 323);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(54, 28);
            this.btnLast.TabIndex = 26;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(381, 18);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(136, 17);
            this.lblPrice.TabIndex = 17;
            this.lblPrice.Text = "Price (CAD) interval:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(758, 323);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(54, 28);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cboCityZone
            // 
            this.cboCityZone.FormattingEnabled = true;
            this.cboCityZone.Location = new System.Drawing.Point(136, 152);
            this.cboCityZone.Name = "cboCityZone";
            this.cboCityZone.Size = new System.Drawing.Size(208, 24);
            this.cboCityZone.TabIndex = 13;
            // 
            // lblCityZone
            // 
            this.lblCityZone.AutoSize = true;
            this.lblCityZone.Location = new System.Drawing.Point(26, 155);
            this.lblCityZone.Name = "lblCityZone";
            this.lblCityZone.Size = new System.Drawing.Size(70, 17);
            this.lblCityZone.TabIndex = 12;
            this.lblCityZone.Text = "City zone:";
            // 
            // txtBathrooms
            // 
            this.txtBathrooms.Location = new System.Drawing.Point(136, 115);
            this.txtBathrooms.Name = "txtBathrooms";
            this.txtBathrooms.Size = new System.Drawing.Size(208, 22);
            this.txtBathrooms.TabIndex = 11;
            // 
            // lblBathrooms
            // 
            this.lblBathrooms.AutoSize = true;
            this.lblBathrooms.Location = new System.Drawing.Point(26, 118);
            this.lblBathrooms.Name = "lblBathrooms";
            this.lblBathrooms.Size = new System.Drawing.Size(80, 17);
            this.lblBathrooms.TabIndex = 10;
            this.lblBathrooms.Text = "Bathrooms:";
            // 
            // txtRooms
            // 
            this.txtRooms.Location = new System.Drawing.Point(136, 80);
            this.txtRooms.Name = "txtRooms";
            this.txtRooms.Size = new System.Drawing.Size(208, 22);
            this.txtRooms.TabIndex = 9;
            // 
            // lblRooms
            // 
            this.lblRooms.AutoSize = true;
            this.lblRooms.Location = new System.Drawing.Point(26, 83);
            this.lblRooms.Name = "lblRooms";
            this.lblRooms.Size = new System.Drawing.Size(56, 17);
            this.lblRooms.TabIndex = 8;
            this.lblRooms.Text = "Rooms:";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(816, 323);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(54, 28);
            this.btnNext.TabIndex = 25;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtAria
            // 
            this.txtAria.Location = new System.Drawing.Point(136, 46);
            this.txtAria.Name = "txtAria";
            this.txtAria.Size = new System.Drawing.Size(208, 22);
            this.txtAria.TabIndex = 7;
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
            this.tablePan.TabIndex = 22;
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
            this.gridAgentHouses.Location = new System.Drawing.Point(20, 357);
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
            this.gridAgentHouses.Size = new System.Drawing.Size(910, 343);
            this.gridAgentHouses.TabIndex = 21;
            // 
            // lblAria
            // 
            this.lblAria.AutoSize = true;
            this.lblAria.Location = new System.Drawing.Point(26, 49);
            this.lblAria.Name = "lblAria";
            this.lblAria.Size = new System.Drawing.Size(70, 17);
            this.lblAria.TabIndex = 6;
            this.lblAria.Text = "Aria (m2):";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(136, 15);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(208, 22);
            this.txtCode.TabIndex = 5;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(26, 18);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(88, 17);
            this.lblCode.TabIndex = 4;
            this.lblCode.Text = "House code:";
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.btnFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.ForeColor = System.Drawing.Color.White;
            this.btnFirst.Location = new System.Drawing.Point(700, 323);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(54, 28);
            this.btnFirst.TabIndex = 23;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // panHouse
            // 
            this.panHouse.BackColor = System.Drawing.Color.Transparent;
            this.panHouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panHouse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panHouse.Controls.Add(this.cboAgent);
            this.panHouse.Controls.Add(this.label1);
            this.panHouse.Controls.Add(this.txtPriceTo);
            this.panHouse.Controls.Add(this.btnSearch);
            this.panHouse.Controls.Add(this.lblAgent);
            this.panHouse.Controls.Add(this.cboStatus);
            this.panHouse.Controls.Add(this.lblStatus);
            this.panHouse.Controls.Add(this.cboType);
            this.panHouse.Controls.Add(this.lblType);
            this.panHouse.Controls.Add(this.lblPrice);
            this.panHouse.Controls.Add(this.txtPriceFrom);
            this.panHouse.Controls.Add(this.cboCityZone);
            this.panHouse.Controls.Add(this.lblCityZone);
            this.panHouse.Controls.Add(this.txtBathrooms);
            this.panHouse.Controls.Add(this.lblBathrooms);
            this.panHouse.Controls.Add(this.txtRooms);
            this.panHouse.Controls.Add(this.lblRooms);
            this.panHouse.Controls.Add(this.txtAria);
            this.panHouse.Controls.Add(this.lblAria);
            this.panHouse.Controls.Add(this.txtCode);
            this.panHouse.Controls.Add(this.lblCode);
            this.panHouse.HorizontalScrollbarBarColor = true;
            this.panHouse.HorizontalScrollbarHighlightOnWheel = false;
            this.panHouse.HorizontalScrollbarSize = 10;
            this.panHouse.Location = new System.Drawing.Point(20, 110);
            this.panHouse.Name = "panHouse";
            this.panHouse.Size = new System.Drawing.Size(909, 199);
            this.panHouse.Style = MetroFramework.MetroColorStyle.Orange;
            this.panHouse.TabIndex = 20;
            this.panHouse.Theme = MetroFramework.MetroThemeStyle.Light;
            this.panHouse.UseStyleColors = true;
            this.panHouse.VerticalScrollbarBarColor = true;
            this.panHouse.VerticalScrollbarHighlightOnWheel = false;
            this.panHouse.VerticalScrollbarSize = 10;
            // 
            // cboAgent
            // 
            this.cboAgent.FormattingEnabled = true;
            this.cboAgent.Location = new System.Drawing.Point(524, 123);
            this.cboAgent.Name = "cboAgent";
            this.cboAgent.Size = new System.Drawing.Size(208, 24);
            this.cboAgent.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(616, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "-";
            // 
            // txtPriceTo
            // 
            this.txtPriceTo.Location = new System.Drawing.Point(635, 15);
            this.txtPriceTo.Name = "txtPriceTo";
            this.txtPriceTo.Size = new System.Drawing.Size(97, 22);
            this.txtPriceTo.TabIndex = 31;
            // 
            // txtPriceFrom
            // 
            this.txtPriceFrom.Location = new System.Drawing.Point(522, 15);
            this.txtPriceFrom.Name = "txtPriceFrom";
            this.txtPriceFrom.Size = new System.Drawing.Size(88, 22);
            this.txtPriceFrom.TabIndex = 16;
            // 
            // frmFindHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 720);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.tablePan);
            this.Controls.Add(this.gridAgentHouses);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.panHouse);
            this.MaximizeBox = false;
            this.Name = "frmFindHouse";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Find House";
            this.Load += new System.EventHandler(this.frmFindHouse_Load);
            this.tablePan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAgentHouses)).EndInit();
            this.panHouse.ResumeLayout(false);
            this.panHouse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblAgent;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cboCityZone;
        private System.Windows.Forms.Label lblCityZone;
        private System.Windows.Forms.TextBox txtBathrooms;
        private System.Windows.Forms.Label lblBathrooms;
        private System.Windows.Forms.TextBox txtRooms;
        private System.Windows.Forms.Label lblRooms;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtAria;
        private MetroFramework.Controls.MetroTile titleHouseCount;
        private System.Windows.Forms.PictureBox pictureHouse;
        private System.Windows.Forms.TableLayoutPanel tablePan;
        private MetroFramework.Controls.MetroGrid gridAgentHouses;
        private System.Windows.Forms.Label lblAria;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Button btnFirst;
        private MetroFramework.Controls.MetroPanel panHouse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPriceTo;
        private System.Windows.Forms.TextBox txtPriceFrom;
        private System.Windows.Forms.ComboBox cboAgent;
    }
}