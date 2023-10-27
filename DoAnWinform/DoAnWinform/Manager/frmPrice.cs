using DevExpress.XtraEditors;
using DoAnWinform.Model;
using DoAnWinform.View;
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
    public partial class frmPrice : DevExpress.XtraEditors.XtraForm
    {
        public frmPrice()
        {
            InitializeComponent();
        }

        private void frmPrice_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            gridDSDG.DataSource = null;
            //Lấy dữ liệu từ CSDL ván vào data gridview
            gridDSDG.DataSource = GetDGViewFromDB();

            //Lấy ra dòng dữ liệu mà user chọn
            //Lấy ra row selected trên datagridview
            var index = gridDSDG.CurrentCell.RowIndex;

            if (index >= 0)
            {
                var dongChon = gridDSDG.Rows[index];
                //Đi vào từng cột để lấy dữ liệu
                string MaKH = dongChon.Cells[0].Value.ToString();
                string MaDG = dongChon.Cells[1].Value.ToString();
                string TenKH = dongChon.Cells[2].Value.ToString();
                string TenDV = dongChon.Cells[3].Value.ToString();
                string DG = dongChon.Cells[4].Value.ToString();
                string SL = dongChon.Cells[5].Value.ToString();
                string ThanhTien = dongChon.Cells[6].Value.ToString();
                //Gán dữ liệu vào textbox
 
                txtMaDG.Text = MaDG;
                txtTenKH.Text = TenKH;
                txtDonGia.Text = DG;
                txtSoLuong.Text = SL;
                
            }
        }

        private List<PriceDetail> GetDGFromDB()
        {
            List<PriceDetail> DSDG = new List<PriceDetail>();
            // Khởi tạo lại đối tượng đại diện cho CSDL
            HotelDbContext dbContext = new HotelDbContext();
            // Vào bảng SV để lấy dữ liệu
            DSDG = dbContext.PriceDetails.ToList();
            return DSDG;
        }
        private List<PriceView> GetDGViewFromDB()
        {
            List<PriceDetail> ls = GetDGFromDB();
            return ls.Select(s => new PriceView
            {
                IDCustomer = s.Price1.IDCustomer,
                IDPrice = s.IDPrice,
                Quantity = s.Quantity,
                Price = s.Price,
                ToTal = tinh(s.Quantity,s.Price),
                ServiceName = s.Price1.Service.ServiceName,
                CustomerName = s.Price1.Customer.CustomerName


            }).ToList();

        }
        private double tinh(int sl, double s)
        {
            return (double)sl * (double)s;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                HotelDbContext dbContext = new HotelDbContext();


                if (txtMaDG.ReadOnly == true)
                {

                    Price editprice = dbContext.Prices.Find(txtMaDG.Text);
                    if (editprice == null)
                    {
                        MessageBox.Show("Mã hoa don không tồn tại");
                    }
                    else
                    {
                        editprice.Customer.CustomerName = txtTenKH.Text;
                        editprice.Quantity = int.Parse(txtSoLuong.Text);
                        editprice.DateOfFounded = DateTime.Parse(dtpdateoffound.Text);
                        dbContext.Entry<Price>(editprice).State = System.Data.Entity.EntityState.Modified;
                        dbContext.SaveChanges();
                        MessageBox.Show("Lưu thành công!");
                    }
                }
                else
                {
                    Price checkExitprice = dbContext.Prices.Find(txtMaDG.Text);
                    if (checkExitprice != null)
                    {
                        MessageBox.Show("Mã hóa đơn đã tồn tại");
                    }
                    else
                    {
                        Price p = new Price();
                        p.IDPrice = txtMaDG.Text;
                        p.Customer.CustomerName = txtTenKH.Text;
                        p.DateOfFounded = DateTime.Parse(dtpdateoffound.Text);
                        p.Quantity = int.Parse(txtSoLuong.Text);
                        dbContext.Prices.Add(p);
                        dbContext.SaveChanges();
                        LoadDataGridView();
                        MessageBox.Show("Lưu thành công!");
                    }
                }
                LoadDataGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message.ToString());
            }
        }

       

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
    }
}