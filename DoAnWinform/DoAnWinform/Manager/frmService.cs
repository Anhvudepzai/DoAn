using DevExpress.XtraEditors;
using DoAnWinform.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnWinform.Manager
{
    public partial class frmService : DevExpress.XtraEditors.XtraForm
    {
        public frmService()
        {
            InitializeComponent();
        }

        private void lblDiaChi_Click(object sender, EventArgs e)
        {

        }

        private void frmService_Load(object sender, EventArgs e)
        {
            LoadGridViewData();
        }

        private void LoadGridViewData()
        {
            gridDSDV.DataSource = null;
            //Lấy dữ liệu từ CSDL ván vào data gridview
            gridDSDV.DataSource = GetDVFromDB();

            //Lấy ra dòng dữ liệu mà user chọn
            //Lấy ra row selected trên datagridview
            var index = gridDSDV.CurrentCell.RowIndex;

            if (index >= 0)
            {
                var dongChon = gridDSDV.Rows[index];
                //Đi vào từng cột để lấy dữ liệu
                string MaDV = dongChon.Cells[0].Value.ToString();
                string TenDV = dongChon.Cells[1].Value.ToString();
                string Gia = dongChon.Cells[2].Value.ToString();
                

                //Gán dữ liệu vào textbox
                txtMaDV.Text = MaDV;
                txtTenDV.Text = TenDV;
                txtGia.Text = Gia;
                

            }
        }

        private List<Service> GetDVFromDB()
        {
            List<Service> DSDV = new List<Service>();
            // Khởi tạo lại đối tượng đại diện cho CSDL
            HotelDbContext dbContext = new HotelDbContext();
            // Vào bảng SV để lấy dữ liệu
            DSDV = dbContext.Services.ToList();

            return DSDV;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            XoaTextBox();
            btnLuu.Enabled = true;
        }

        private void XoaTextBox()
        {
            txtMaDV.ReadOnly = false;
            txtMaDV.Text = string.Empty;
            txtTenDV.ReadOnly = false;
            txtTenDV.Text = string.Empty;
            txtGia.ReadOnly = false;
            txtGia.Text = string.Empty;
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            txtMaDV.ReadOnly = true;
            txtTenDV.ReadOnly = false;
            txtGia.ReadOnly = false;
          
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                //KHởi tạo DBCOntext
                HotelDbContext dbContext = new HotelDbContext();

                //Kiểm tra thêm hoặc sửa

                if (txtMaDV.ReadOnly == true)
                {
                    //Sửa
                    //Lấy ra NV cần sửa
                    Service editDV = dbContext.Services.Find(txtMaDV.Text);
                    //Nếu tìm được
                    if (editDV == null)
                    {
                        MessageBox.Show("Dịch Vụ không tồn tại");
                    }
                    else
                    {
                        editDV.ServiceName = txtTenDV.Text;
                        


                        dbContext.Entry<Service>(editDV).State = System.Data.Entity.EntityState.Modified;
                        dbContext.SaveChanges();
                        MessageBox.Show("Lưu thành công!");
                    }

                }
                else
                {
                    //thêm
                    //Kiểm tra mssv đã tồn tại hay chưa
                    Service checkExitDV = dbContext.Services.Find(txtMaDV.Text);
                    //Nếu tìm được
                    if (checkExitDV != null)
                    {
                        MessageBox.Show("Mã DV đã tồn tại");
                    }
                    else
                    {
                        Service dv = new Service();
                        dv.ServiceName = txtTenDV.Text;
                        dv.IDService = txtMaDV.Text;
                        dv.Price = float.Parse(txtGia.Text);
                        


                        //Thêm sinh viên vào csdl
                        // Add dữ liệu vào 1 bảng
                        dbContext.Services.Add(dv);

                        //GỌi phương thức lưu vào DB
                        dbContext.SaveChanges();
                        LoadGridViewData();
                        MessageBox.Show("Lưu thành công!");
                    }
                }
                XoaTextBox();
                LoadGridViewData();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message.ToString());
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //KHởi tạo DBCOntext
            HotelDbContext dbContext = new HotelDbContext();
            //Tìm ra KH cần xóa
            var Delete = dbContext.Services.Find(txtMaDV.Text);
            if (Delete != null)
            {
                // Xóa khỏi bảng khách hàng
                dbContext.Services.Remove(Delete);
                //Lưu thay đổi vào CSDL
                dbContext.SaveChanges();
            }
            else
            {
                MessageBox.Show("Không tìm thấy DV cần xóa");
            }

            LoadGridViewData();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {

        }

        private void gridDSDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = gridDSDV.CurrentCell.RowIndex;

            if (index >= 0)
            {
                var dongChon = gridDSDV.Rows[index];
                //Đi vào từng cột để lấy dữ liệu
                string MaDV = dongChon.Cells[0].Value.ToString();
                string TenDV = dongChon.Cells[1].Value.ToString();
                string Gia = dongChon.Cells[2].Value.ToString();


                //Gán dữ liệu vào textbox
                txtMaDV.Text = MaDV;
                txtTenDV.Text = TenDV;
                txtGia.Text = Gia;


            }
        }
    }
}