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
    public partial class frmEmployee : DevExpress.XtraEditors.XtraForm
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            LoadGridViewData();
        }
        private void LoadGridViewData()
        {
            gridDSNV.DataSource = null;
            //Lấy dữ liệu từ CSDL ván vào data gridview
            gridDSNV.DataSource = GetNVFromDB();

            //Lấy ra dòng dữ liệu mà user chọn
            //Lấy ra row selected trên datagridview
            var index = gridDSNV.CurrentCell.RowIndex;

            if (index >= 0)
            {
                var dongChon = gridDSNV.Rows[index];
                //Đi vào từng cột để lấy dữ liệu
                string MaNV = dongChon.Cells[0].Value.ToString();
                string TenNV = dongChon.Cells[1].Value.ToString();
                string Gender = dongChon.Cells[2].Value.ToString();
                string Sdt = dongChon.Cells[3].Value.ToString();
                string Diachi = dongChon.Cells[4].Value.ToString();
               
                //Gán dữ liệu vào textbox
                txtMaNV.Text = MaNV;
                txtTenNV.Text = TenNV;

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
        private List<Employee> GetNVFromDB()
        {
            List<Employee> DSNV = new List<Employee>();
            // Khởi tạo lại đối tượng đại diện cho CSDL
            HotelDbContext dbContext = new HotelDbContext();
            // Vào bảng SV để lấy dữ liệu
            DSNV = dbContext.Employees.ToList();

            return DSNV;
        }

        private void gridDSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = gridDSNV.CurrentCell.RowIndex;

            if (index >= 0)
            {
                var dongChon = gridDSNV.Rows[index];
                //Đi vào từng cột để lấy dữ liệu
                string MaNV = dongChon.Cells[0].Value.ToString();
                string TenNV = dongChon.Cells[1].Value.ToString();
                string Gender = dongChon.Cells[2].Value.ToString();
                string Sdt = dongChon.Cells[3].Value.ToString();
                string Diachi = dongChon.Cells[4].Value.ToString();
                string Email = dongChon.Cells[5].Value.ToString();
                //Gán dữ liệu vào textbox
                txtMaNV.Text = MaNV;
                txtTenNV.Text = TenNV;

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

        private void btnThem_Click(object sender, EventArgs e)
        {
            XoaTextBox();
            btnLuu.Enabled = true;
        }

        private void XoaTextBox()
        {
            txtMaNV.ReadOnly = false;
            txtMaNV.Text = string.Empty;
            txtTenNV.ReadOnly = false;
            txtTenNV.Text = string.Empty;
            txtSdt.ReadOnly = false;
            txtSdt.Text = string.Empty;
            txtDiaChi.ReadOnly = false;
            txtDiaChi.Text = string.Empty;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            txtMaNV.ReadOnly = true;
            txtTenNV.ReadOnly = false;
            txtSdt.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //KHởi tạo DBCOntext
            HotelDbContext dbContext = new HotelDbContext();
            //Tìm ra KH cần xóa
            var Delete = dbContext.Employees.Find(txtMaNV.Text);
            if (Delete != null)
            {
                // Xóa khỏi bảng khách hàng
                dbContext.Employees.Remove(Delete);
                //Lưu thay đổi vào CSDL
                dbContext.SaveChanges();
            }
            else
            {
                MessageBox.Show("Không tìm thấy NV cần xóa");
            }

            LoadGridViewData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                //KHởi tạo DBCOntext
                HotelDbContext dbContext = new HotelDbContext();

                //Kiểm tra thêm hoặc sửa

                if (txtMaNV.ReadOnly == true)
                {
                    //Sửa
                    //Lấy ra NV cần sửa
                    Employee editNV = dbContext.Employees.Find(txtMaNV.Text);
                    //Nếu tìm được
                    if (editNV == null)
                    {
                        MessageBox.Show("Nhân viên không tồn tại");
                    }
                    else
                    {
                        editNV.EmployeeName = txtTenNV.Text;
                        editNV.PhoneNumber = txtSdt.Text;
                        editNV.Address = txtDiaChi.Text;


                        if (rdbNam.Checked == true)
                        {
                            editNV.Gender = "Nam";
                        }
                        else
                        {
                            editNV.Gender = "Nữ";
                        }

                        dbContext.Entry<Employee>(editNV).State = System.Data.Entity.EntityState.Modified;
                        dbContext.SaveChanges();
                        MessageBox.Show("Lưu thành công!");
                    }

                }
                else
                {
                    //thêm
                    //Kiểm tra mssv đã tồn tại hay chưa
                    Employee checkExitNV = dbContext.Employees.Find(txtMaNV.Text);
                    //Nếu tìm được
                    if (checkExitNV != null)
                    {
                        MessageBox.Show("Mã NV đã tồn tại");
                    }
                    else
                    {
                        Employee nv = new Employee();
                        nv.EmployeeName = txtTenNV.Text;
                        nv.IDEmployee = txtMaNV.Text;
                        nv.PhoneNumber = txtSdt.Text;
                        nv.Address = txtDiaChi.Text;

                        if (rdbNam.Checked || rdbNu.Checked)
                        {
                            nv.Gender = "Nam";
                        }
                        else
                        {

                            nv.Gender = "Không xác định";
                        }


                        //Thêm sinh viên vào csdl
                        // Add dữ liệu vào 1 bảng
                        dbContext.Employees.Add(nv);

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

        private void btnImport_Click(object sender, EventArgs e)
        {

        }

        private void txtTimMaNV_TextChanged(object sender, EventArgs e)
        {
            string maNV = txtTimMaNV.Text;

            List<Employee> lstNVSearch = GetNVFromDB().Where(s => s.IDEmployee.StartsWith(maNV)
                                                     ).ToList();
            //Hiển thị lại dữ liệu trên datagridview
            gridDSNV.DataSource = null;
            gridDSNV.DataSource = lstNVSearch;
        }
    }

  

 }
