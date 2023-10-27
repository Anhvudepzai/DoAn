namespace DoAnWinform.Manager
{
    partial class frmBooking
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridDSDP = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnDP = new System.Windows.Forms.ToolStripButton();
            this.btnHuy = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.lblGia = new System.Windows.Forms.Label();
            this.cbbKhachHang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbRoom = new System.Windows.Forms.ComboBox();
            this.lblPhong = new System.Windows.Forms.Label();
            this.lblNgayTra = new System.Windows.Forms.Label();
            this.lblNgayDat = new System.Windows.Forms.Label();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayDat = new System.Windows.Forms.DateTimePicker();
            this.txtMaDP = new System.Windows.Forms.TextBox();
            this.lblMaDP = new System.Windows.Forms.Label();
            this.roomBookingViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDRoomBookingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDRoomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBookingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toTalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDSDP)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomBookingViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtGia);
            this.groupBox3.Controls.Add(this.lblGia);
            this.groupBox3.Controls.Add(this.cbbKhachHang);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cbbRoom);
            this.groupBox3.Controls.Add(this.lblPhong);
            this.groupBox3.Controls.Add(this.lblNgayTra);
            this.groupBox3.Controls.Add(this.lblNgayDat);
            this.groupBox3.Controls.Add(this.dtpNgayTra);
            this.groupBox3.Controls.Add(this.dtpNgayDat);
            this.groupBox3.Controls.Add(this.txtMaDP);
            this.groupBox3.Controls.Add(this.lblMaDP);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 269);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1179, 277);
            this.groupBox3.TabIndex = 61;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin đặt phòng";
            // 
            // gridDSDP
            // 
            this.gridDSDP.AutoGenerateColumns = false;
            this.gridDSDP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDSDP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDRoomBookingDataGridViewTextBoxColumn,
            this.iDRoomDataGridViewTextBoxColumn,
            this.dateOfBookingDataGridViewTextBoxColumn,
            this.dateOfEndDataGridViewTextBoxColumn,
            this.iDCustomerDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.toTalDataGridViewTextBoxColumn});
            this.gridDSDP.DataSource = this.roomBookingViewBindingSource;
            this.gridDSDP.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridDSDP.Location = new System.Drawing.Point(0, 31);
            this.gridDSDP.Name = "gridDSDP";
            this.gridDSDP.RowHeadersWidth = 51;
            this.gridDSDP.RowTemplate.Height = 24;
            this.gridDSDP.Size = new System.Drawing.Size(1179, 220);
            this.gridDSDP.TabIndex = 60;
            this.gridDSDP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDSDP_CellClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDP,
            this.btnHuy,
            this.btnThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1179, 31);
            this.toolStrip1.TabIndex = 59;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnDP
            // 
            this.btnDP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDP.Name = "btnDP";
            this.btnDP.Size = new System.Drawing.Size(84, 28);
            this.btnDP.Text = "Đặt phòng";
            this.btnDP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDP.Click += new System.EventHandler(this.btnDP_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(39, 28);
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(51, 28);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(820, 154);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(173, 23);
            this.txtGia.TabIndex = 40;
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(755, 162);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(25, 16);
            this.lblGia.TabIndex = 39;
            this.lblGia.Text = "Giá";
            // 
            // cbbKhachHang
            // 
            this.cbbKhachHang.FormattingEnabled = true;
            this.cbbKhachHang.Items.AddRange(new object[] {
            "Phong trong",
            "Phong dang su dung",
            "Phong duoc dat truoc"});
            this.cbbKhachHang.Location = new System.Drawing.Point(337, 157);
            this.cbbKhachHang.Name = "cbbKhachHang";
            this.cbbKhachHang.Size = new System.Drawing.Size(173, 24);
            this.cbbKhachHang.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Khách Hàng";
            // 
            // cbbRoom
            // 
            this.cbbRoom.FormattingEnabled = true;
            this.cbbRoom.Items.AddRange(new object[] {
            "Phong trong",
            "Phong dang su dung",
            "Phong duoc dat truoc"});
            this.cbbRoom.Location = new System.Drawing.Point(337, 101);
            this.cbbRoom.Name = "cbbRoom";
            this.cbbRoom.Size = new System.Drawing.Size(173, 24);
            this.cbbRoom.TabIndex = 34;
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Location = new System.Drawing.Point(233, 104);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(42, 16);
            this.lblPhong.TabIndex = 33;
            this.lblPhong.Text = "Phòng";
            // 
            // lblNgayTra
            // 
            this.lblNgayTra.AutoSize = true;
            this.lblNgayTra.Location = new System.Drawing.Point(755, 101);
            this.lblNgayTra.Name = "lblNgayTra";
            this.lblNgayTra.Size = new System.Drawing.Size(59, 16);
            this.lblNgayTra.TabIndex = 32;
            this.lblNgayTra.Text = "Ngày Trả";
            // 
            // lblNgayDat
            // 
            this.lblNgayDat.AutoSize = true;
            this.lblNgayDat.Location = new System.Drawing.Point(755, 40);
            this.lblNgayDat.Name = "lblNgayDat";
            this.lblNgayDat.Size = new System.Drawing.Size(59, 16);
            this.lblNgayDat.TabIndex = 31;
            this.lblNgayDat.Text = "Ngày Đặt";
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTra.Location = new System.Drawing.Point(872, 96);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(98, 23);
            this.dtpNgayTra.TabIndex = 30;
            // 
            // dtpNgayDat
            // 
            this.dtpNgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDat.Location = new System.Drawing.Point(872, 37);
            this.dtpNgayDat.Name = "dtpNgayDat";
            this.dtpNgayDat.Size = new System.Drawing.Size(98, 23);
            this.dtpNgayDat.TabIndex = 29;
            // 
            // txtMaDP
            // 
            this.txtMaDP.Location = new System.Drawing.Point(337, 40);
            this.txtMaDP.Name = "txtMaDP";
            this.txtMaDP.Size = new System.Drawing.Size(173, 23);
            this.txtMaDP.TabIndex = 28;
            // 
            // lblMaDP
            // 
            this.lblMaDP.AutoSize = true;
            this.lblMaDP.Location = new System.Drawing.Point(233, 43);
            this.lblMaDP.Name = "lblMaDP";
            this.lblMaDP.Size = new System.Drawing.Size(87, 16);
            this.lblMaDP.TabIndex = 27;
            this.lblMaDP.Text = "Mã Đặt Phòng";
            // 
            // roomBookingViewBindingSource
            // 
            this.roomBookingViewBindingSource.DataSource = typeof(DoAnWinform.Model.View.RoomBookingView);
            // 
            // iDRoomBookingDataGridViewTextBoxColumn
            // 
            this.iDRoomBookingDataGridViewTextBoxColumn.DataPropertyName = "IDRoomBooking";
            this.iDRoomBookingDataGridViewTextBoxColumn.HeaderText = "IDRoomBooking";
            this.iDRoomBookingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDRoomBookingDataGridViewTextBoxColumn.Name = "iDRoomBookingDataGridViewTextBoxColumn";
            this.iDRoomBookingDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDRoomDataGridViewTextBoxColumn
            // 
            this.iDRoomDataGridViewTextBoxColumn.DataPropertyName = "IDRoom";
            this.iDRoomDataGridViewTextBoxColumn.HeaderText = "IDRoom";
            this.iDRoomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDRoomDataGridViewTextBoxColumn.Name = "iDRoomDataGridViewTextBoxColumn";
            this.iDRoomDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateOfBookingDataGridViewTextBoxColumn
            // 
            this.dateOfBookingDataGridViewTextBoxColumn.DataPropertyName = "DateOfBooking";
            this.dateOfBookingDataGridViewTextBoxColumn.HeaderText = "DateOfBooking";
            this.dateOfBookingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateOfBookingDataGridViewTextBoxColumn.Name = "dateOfBookingDataGridViewTextBoxColumn";
            this.dateOfBookingDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateOfEndDataGridViewTextBoxColumn
            // 
            this.dateOfEndDataGridViewTextBoxColumn.DataPropertyName = "DateOfEnd";
            this.dateOfEndDataGridViewTextBoxColumn.HeaderText = "DateOfEnd";
            this.dateOfEndDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateOfEndDataGridViewTextBoxColumn.Name = "dateOfEndDataGridViewTextBoxColumn";
            this.dateOfEndDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDCustomerDataGridViewTextBoxColumn
            // 
            this.iDCustomerDataGridViewTextBoxColumn.DataPropertyName = "IDCustomer";
            this.iDCustomerDataGridViewTextBoxColumn.HeaderText = "IDCustomer";
            this.iDCustomerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDCustomerDataGridViewTextBoxColumn.Name = "iDCustomerDataGridViewTextBoxColumn";
            this.iDCustomerDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // toTalDataGridViewTextBoxColumn
            // 
            this.toTalDataGridViewTextBoxColumn.DataPropertyName = "ToTal";
            this.toTalDataGridViewTextBoxColumn.HeaderText = "ToTal";
            this.toTalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.toTalDataGridViewTextBoxColumn.Name = "toTalDataGridViewTextBoxColumn";
            this.toTalDataGridViewTextBoxColumn.Width = 125;
            // 
            // frmBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 546);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gridDSDP);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmBooking";
            this.Text = "frmBooking";
            this.Load += new System.EventHandler(this.frmBooking_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDSDP)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomBookingViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gridDSDP;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnDP;
        private System.Windows.Forms.ToolStripButton btnHuy;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.ComboBox cbbKhachHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbRoom;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.Label lblNgayTra;
        private System.Windows.Forms.Label lblNgayDat;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.DateTimePicker dtpNgayDat;
        private System.Windows.Forms.TextBox txtMaDP;
        private System.Windows.Forms.Label lblMaDP;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRoomBookingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRoomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBookingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toTalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource roomBookingViewBindingSource;
    }
}