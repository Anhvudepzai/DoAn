namespace DoAnWinform.Manager
{
    partial class frmRoom
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
            this.txtTimMaPhong = new System.Windows.Forms.TextBox();
            this.lblTimMaPhong = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSoPhong = new System.Windows.Forms.TextBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.lblSoPhong = new System.Windows.Forms.Label();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.gridDSP = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnImport = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.cbbTrangThai = new System.Windows.Forms.ComboBox();
            this.cbbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.lblLoaiPhong = new System.Windows.Forms.Label();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDRoomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfRoomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDRoomTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDSP)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimMaPhong
            // 
            this.txtTimMaPhong.Location = new System.Drawing.Point(735, 266);
            this.txtTimMaPhong.Name = "txtTimMaPhong";
            this.txtTimMaPhong.Size = new System.Drawing.Size(234, 23);
            this.txtTimMaPhong.TabIndex = 58;
            this.txtTimMaPhong.TextChanged += new System.EventHandler(this.txtTimMaPhong_TextChanged);
            // 
            // lblTimMaPhong
            // 
            this.lblTimMaPhong.AutoSize = true;
            this.lblTimMaPhong.Location = new System.Drawing.Point(598, 269);
            this.lblTimMaPhong.Name = "lblTimMaPhong";
            this.lblTimMaPhong.Size = new System.Drawing.Size(120, 16);
            this.lblTimMaPhong.TabIndex = 57;
            this.lblTimMaPhong.Text = "Tìm kiếm Mã Phòng";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbbLoaiPhong);
            this.groupBox3.Controls.Add(this.lblLoaiPhong);
            this.groupBox3.Controls.Add(this.cbbTrangThai);
            this.groupBox3.Controls.Add(this.txtSoPhong);
            this.groupBox3.Controls.Add(this.lblTrangThai);
            this.groupBox3.Controls.Add(this.txtMaPhong);
            this.groupBox3.Controls.Add(this.lblSoPhong);
            this.groupBox3.Controls.Add(this.lblMaPhong);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 333);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1089, 163);
            this.groupBox3.TabIndex = 61;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin phòng";
            // 
            // txtSoPhong
            // 
            this.txtSoPhong.Location = new System.Drawing.Point(252, 82);
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.Size = new System.Drawing.Size(234, 23);
            this.txtSoPhong.TabIndex = 36;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(649, 36);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(70, 16);
            this.lblTrangThai.TabIndex = 30;
            this.lblTrangThai.Text = "Trạng Thái";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(252, 29);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(235, 23);
            this.txtMaPhong.TabIndex = 24;
            // 
            // lblSoPhong
            // 
            this.lblSoPhong.AutoSize = true;
            this.lblSoPhong.Location = new System.Drawing.Point(139, 82);
            this.lblSoPhong.Name = "lblSoPhong";
            this.lblSoPhong.Size = new System.Drawing.Size(61, 16);
            this.lblSoPhong.TabIndex = 23;
            this.lblSoPhong.Text = "Số Phòng";
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.AutoSize = true;
            this.lblMaPhong.Location = new System.Drawing.Point(139, 29);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(63, 16);
            this.lblMaPhong.TabIndex = 22;
            this.lblMaPhong.Text = "Mã phòng";
            // 
            // gridDSP
            // 
            this.gridDSP.AutoGenerateColumns = false;
            this.gridDSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDRoomDataGridViewTextBoxColumn,
            this.numberOfRoomDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.iDRoomTypeDataGridViewTextBoxColumn});
            this.gridDSP.DataSource = this.roomBindingSource;
            this.gridDSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridDSP.Location = new System.Drawing.Point(0, 31);
            this.gridDSP.Name = "gridDSP";
            this.gridDSP.RowHeadersWidth = 51;
            this.gridDSP.RowTemplate.Height = 24;
            this.gridDSP.Size = new System.Drawing.Size(1089, 220);
            this.gridDSP.TabIndex = 60;
            this.gridDSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDSP_CellClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnLuu,
            this.btnImport,
            this.btnThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1089, 31);
            this.toolStrip1.TabIndex = 59;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThem
            // 
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(50, 28);
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(38, 28);
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(39, 28);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(37, 28);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnImport
            // 
            this.btnImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(58, 28);
            this.btnImport.Text = "Import";
            this.btnImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(51, 28);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // cbbTrangThai
            // 
            this.cbbTrangThai.FormattingEnabled = true;
            this.cbbTrangThai.Location = new System.Drawing.Point(735, 29);
            this.cbbTrangThai.Name = "cbbTrangThai";
            this.cbbTrangThai.Size = new System.Drawing.Size(151, 24);
            this.cbbTrangThai.TabIndex = 42;
            // 
            // cbbLoaiPhong
            // 
            this.cbbLoaiPhong.FormattingEnabled = true;
            this.cbbLoaiPhong.Location = new System.Drawing.Point(735, 74);
            this.cbbLoaiPhong.Name = "cbbLoaiPhong";
            this.cbbLoaiPhong.Size = new System.Drawing.Size(151, 24);
            this.cbbLoaiPhong.TabIndex = 44;
            // 
            // lblLoaiPhong
            // 
            this.lblLoaiPhong.AutoSize = true;
            this.lblLoaiPhong.Location = new System.Drawing.Point(649, 82);
            this.lblLoaiPhong.Name = "lblLoaiPhong";
            this.lblLoaiPhong.Size = new System.Drawing.Size(69, 16);
            this.lblLoaiPhong.TabIndex = 43;
            this.lblLoaiPhong.Text = "Loại Phòng";
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataSource = typeof(DoAnWinform.Model.Room);
            // 
            // iDRoomDataGridViewTextBoxColumn
            // 
            this.iDRoomDataGridViewTextBoxColumn.DataPropertyName = "IDRoom";
            this.iDRoomDataGridViewTextBoxColumn.HeaderText = "IDRoom";
            this.iDRoomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDRoomDataGridViewTextBoxColumn.Name = "iDRoomDataGridViewTextBoxColumn";
            this.iDRoomDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberOfRoomDataGridViewTextBoxColumn
            // 
            this.numberOfRoomDataGridViewTextBoxColumn.DataPropertyName = "NumberOfRoom";
            this.numberOfRoomDataGridViewTextBoxColumn.HeaderText = "NumberOfRoom";
            this.numberOfRoomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberOfRoomDataGridViewTextBoxColumn.Name = "numberOfRoomDataGridViewTextBoxColumn";
            this.numberOfRoomDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDRoomTypeDataGridViewTextBoxColumn
            // 
            this.iDRoomTypeDataGridViewTextBoxColumn.DataPropertyName = "IDRoomType";
            this.iDRoomTypeDataGridViewTextBoxColumn.HeaderText = "RoomType";
            this.iDRoomTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDRoomTypeDataGridViewTextBoxColumn.Name = "iDRoomTypeDataGridViewTextBoxColumn";
            this.iDRoomTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // frmRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 496);
            this.Controls.Add(this.txtTimMaPhong);
            this.Controls.Add(this.lblTimMaPhong);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gridDSP);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmRoom";
            this.Text = "frmRoom";
            this.Load += new System.EventHandler(this.frmRoom_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDSP)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimMaPhong;
        private System.Windows.Forms.Label lblTimMaPhong;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSoPhong;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label lblSoPhong;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.DataGridView gridDSP;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnImport;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private System.Windows.Forms.ComboBox cbbLoaiPhong;
        private System.Windows.Forms.Label lblLoaiPhong;
        private System.Windows.Forms.ComboBox cbbTrangThai;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRoomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfRoomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRoomTypeDataGridViewTextBoxColumn;
    }
}