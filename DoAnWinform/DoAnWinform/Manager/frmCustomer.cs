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
    public partial class frmCustomer : DevExpress.XtraEditors.XtraForm
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            LoadGridViewData();
        }
        private void LoadGridViewData()
        {
            gridDSKH.DataSource = null;
            //Lấy dữ liệu từ CSDL ván vào data gridview
            gridDSKH.DataSource = GetKHFromDB();

            //Lấy ra dòng dữ liệu mà user chọn
            //Lấy ra row selected trên datagridview
            var index = gridDSKH.CurrentCell.RowIndex;

            if (index >= 0)
            {
                var dongChon = gridDSKH.Rows[index];
                //Đi vào từng cột để lấy dữ liệu
                string MaKH = dongChon.Cells[0].Value.ToString();
                string TenKH = dongChon.Cells[1].Value.ToString();
                string Gender = dongChon.Cells[2].Value.ToString();
                string Sdt = dongChon.Cells[3].Value.ToString();
                string Diachi = dongChon.Cells[4].Value.ToString();
                //Gán dữ liệu vào textbox
                txtMaKH.Text = MaKH;
                txtTenKH.Text = TenKH;
                if (Gender == "Nam")
                {
                    rdbNam.Checked = true;
                }
                else
                {
                    rdbNu.Checked = true;
                }
                txtSdt.Text = Sdt;
                txtDiaChi.Text = Diachi;
            }
        }

        private List<Customer> GetKHFromDB()
        {
            List<Customer> DSKH = new List<Customer>();
            // Khởi tạo lại đối tượng đại diện cho CSDL
            HotelDbContext dbContext = new HotelDbContext();
            // Vào bảng SV để lấy dữ liệu
            DSKH = dbContext.Customers.ToList();

            return DSKH;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            XoaTextBox();
            btnLuu.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            txtMaKH.ReadOnly = true;
            txtTenKH.ReadOnly = false;
            txtSdt.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                //KHởi tạo DBCOntext
                HotelDbContext dbContext = new HotelDbContext();

                //Kiểm tra thêm hoặc sửa

                if (txtMaKH.ReadOnly == true)
                {
                    //Sửa
                    //Lấy ra KH cần sửa
                    Customer editKH = dbContext.Customers.Find(txtMaKH.Text);
                    //Nếu tìm được
                    if (editKH == null)
                    {
                        MessageBox.Show("Khách hàng không tồn tại");
                    }
                    else
                    {
                        editKH.CustomerName = txtTenKH.Text;
                        editKH.NumberPhone = txtSdt.Text;
                        editKH.Address = txtDiaChi.Text;
                        if (rdbNam.Checked == true)
                        {
                            editKH.Gender = "Nam";
                        }
                        else
                        {
                            editKH.Gender = "Nữ";
                        }

                        dbContext.Entry<Customer>(editKH).State = System.Data.Entity.EntityState.Modified;
                        dbContext.SaveChanges();
                        MessageBox.Show("Lưu thành công!");
                    }

                }
                else
                {
                    //thêm
                    //Kiểm tra mssv đã tồn tại hay chưa
                    Customer checkExitKH = dbContext.Customers.Find(txtMaKH.Text);
                    //Nếu tìm được
                    if (checkExitKH != null)
                    {
                        MessageBox.Show("Mã KH đã tồn tại");
                    }
                    else
                    {
                        Customer kh = new Customer();
                        kh.CustomerName = txtTenKH.Text;
                        kh.IDCustomer = txtMaKH.Text;
                        kh.NumberPhone = txtSdt.Text;
                        kh.Address = txtDiaChi.Text;

                        if (rdbNam.Checked )
                        {
                            kh.Gender = "Nam";
                        }
                        else
                        {

                            kh.Gender = "Nữ";
                        }


                        //Thêm sinh viên vào csdl
                        // Add dữ liệu vào 1 bảng
                        dbContext.Customers.Add(kh);

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

        private void XoaTextBox()
        {
            txtMaKH.ReadOnly = false;
            txtMaKH.Text = string.Empty;
            txtTenKH.ReadOnly = false;
            txtTenKH.Text = string.Empty;
            txtSdt.ReadOnly = false;
            txtSdt.Text = string.Empty;
            txtDiaChi.ReadOnly = false;
            txtDiaChi.Text = string.Empty;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //KHởi tạo DBCOntext
            HotelDbContext dbContext = new HotelDbContext();
            //Tìm ra KH cần xóa
            var Delete = dbContext.Customers.Find(txtMaKH.Text);
            if (Delete != null)
            {
                // Xóa khỏi bảng khách hàng
                dbContext.Customers.Remove(Delete);
                //Lưu thay đổi vào CSDL
                dbContext.SaveChanges();
            }
            else
            {
                MessageBox.Show("Không tìm thấy KH cần xóa");
            }

            LoadGridViewData();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {

        }

        private void gridDSKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = gridDSKH.CurrentCell.RowIndex;

            if (index >= 0)
            {
                var dongChon = gridDSKH.Rows[index];
                //Đi vào từng cột để lấy dữ liệu
                string MaKH = dongChon.Cells[0].Value.ToString();
                string TenKH = dongChon.Cells[1].Value.ToString();
                string Gender = dongChon.Cells[2].Value.ToString();
                string Sdt = dongChon.Cells[3].Value.ToString();
                string Diachi = dongChon.Cells[4].Value.ToString();
                //Gán dữ liệu vào textbox
                txtMaKH.Text = MaKH;
                txtTenKH.Text = TenKH;
                if (Gender == "Nam")
                {
                    rdbNam.Checked = true;
                }
                else
                {
                    rdbNu.Checked = true;
                }
                txtSdt.Text = Sdt;
                txtDiaChi.Text = Diachi;
            }
        }

        private void txtTimMaKH_TextChanged(object sender, EventArgs e)
        {

            string maKH = txtTimMaKH.Text;

            List<Customer> lstKHSearch = GetKHFromDB().Where(s => s.IDCustomer.StartsWith(maKH)
                                                     ).ToList();
            //Hiển thị lại dữ liệu trên datagridview
            gridDSKH.DataSource = null;
            gridDSKH.DataSource = lstKHSearch;
        }

        //private List<CustomerView> GetKHViewFromDB()
        //{
        //    List<Customer> ls = GetKHFromDB();
        //    return ls.Select(s => new CustomerView
        //    {
        //        IDCustomer = s.IDCustomer,
        //        CustomerName = s.CustomerName,
        //        Gender = s.Gender == "Nam" ? "Nam" : "Nữ",
        //        NumberPhone = s.NumberPhone,
        //        Address = s.Address,

        //    }).ToList();

    }









    }


