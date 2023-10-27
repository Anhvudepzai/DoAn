using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DoAnWinform.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations.History;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnWinform.Manager
{
    public partial class frmRoom : DevExpress.XtraEditors.XtraForm
    {
        public frmRoom()
        {
            InitializeComponent();
        }

        private void frmRoom_Load(object sender, EventArgs e)
        {
            LoadGridViewData();
            fillcbb();
        }

        private void fillcbb()
        {
            HotelDbContext dbContext = new HotelDbContext();
            List<RoomType> listphong = dbContext.RoomTypes.ToList();
            cbbLoaiPhong.DataSource = listphong;
            cbbLoaiPhong.DisplayMember = "RoomTypeName";
            cbbLoaiPhong.ValueMember = "IDRoomType";
        }

        private void LoadGridViewData()
        {
            try
            {
                gridDSP.DataSource = null;
                gridDSP.DataSource = GetRoomViewFromDB();

                var index = gridDSP.CurrentCell.RowIndex;
                if (index >= 0)
                {
                    var chon = gridDSP.Rows[index];
                    string roomid = chon.Cells[0].Value.ToString();
                    string status = chon.Cells[1].Value.ToString();
                    string numberofroom = chon.Cells[2].Value.ToString();
                    string roomtype = chon.Cells[3].Value.ToString();
                    txtMaPhong.Text = roomid;
                    txtSoPhong.Text = numberofroom;
                    cbbTrangThai.Text = status;
                    cbbLoaiPhong.Text = roomtype;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private List<RoomView> GetRoomViewFromDB()
        {
            List<Room> lr = GetRoomFromDB();
            return lr.Select(s => new RoomView
            {
                IDRoom = s.IDRoom,
                NumberOfRoom = (int)s.NumberOfRoom,
                Status = s.Status,
                IDRoomType = s.RoomType.RoomTypeName,

            }).ToList();
        }

        private List<Room> GetRoomFromDB()
        {
            List<Room> r = new List<Room>();
           HotelDbContext db = new HotelDbContext();
            r = db.Rooms.ToList();
            return r;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                HotelDbContext dbContext = new HotelDbContext();


                if (txtMaPhong.ReadOnly == true)
                {

                    Room editroom = dbContext.Rooms.Find(txtMaPhong.Text);
                    if (editroom == null)
                    {
                        MessageBox.Show("Mã phòng không tồn tại");
                    }
                    else
                    {
                        editroom.IDRoom = txtMaPhong.Text;
                        editroom.NumberOfRoom = int.Parse(txtSoPhong.Text);
                        editroom.Status = cbbTrangThai.Text;
                        editroom.IDRoomType = cbbLoaiPhong.SelectedValue.ToString();
                        dbContext.Entry<Room>(editroom).State = System.Data.Entity.EntityState.Modified;
                        dbContext.SaveChanges();
                        MessageBox.Show("Lưu thành công!");
                    }

                }
                else
                {
                    Room checkExitRoom = dbContext.Rooms.Find(txtMaPhong.Text);
                    if (checkExitRoom != null)
                    {
                        MessageBox.Show("Mã phòng đã tồn tại");
                    }
                    else
                    {
                        Room r = new Room();
                        r.IDRoom = txtMaPhong.Text;
                        r.NumberOfRoom = int.Parse(txtSoPhong.Text);
                        r.Status = cbbTrangThai.Text;
                        r.IDRoomType = cbbLoaiPhong.SelectedValue.ToString();
                        dbContext.Rooms.Add(r);
                        dbContext.SaveChanges();
                        LoadGridViewData();
                        MessageBox.Show("Lưu thành công!");
                    }
                }
                LoadGridViewData();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message.ToString());
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            XoaTextBox();
            btnLuu.Enabled = true;
        }

        private void XoaTextBox()
        {
            txtMaPhong.ReadOnly = false;
            txtMaPhong.Text = string.Empty;
            txtSoPhong.ReadOnly = false;
            txtSoPhong.Text = string.Empty;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            txtMaPhong.ReadOnly = true;
            txtSoPhong.ReadOnly = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            HotelDbContext dbContext = new HotelDbContext();
            var RoomDelete = dbContext.Rooms.Find(txtMaPhong.Text);
            if (RoomDelete != null)
            {
                dbContext.Rooms.Remove(RoomDelete);
                dbContext.SaveChanges();
            }
            else
            {
                MessageBox.Show("Không tìm thấy phòng cần xóa");
            }

            LoadGridViewData();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {

        }

        private void gridDSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            var index = gridDSP.CurrentCell.RowIndex;
            if (index >= 0)
            {
                var chon = gridDSP.Rows[index];
                string roomid = chon.Cells[0].Value.ToString();
                string status = chon.Cells[1].Value.ToString();
                string numberofroom = chon.Cells[2].Value.ToString();
                string roomtype = chon.Cells[3].Value.ToString();
                txtMaPhong.Text = roomid;
                txtSoPhong.Text = numberofroom;
                cbbTrangThai.Text = status;
                cbbLoaiPhong.Text = roomtype;
            }
        }

        private void txtTimMaPhong_TextChanged(object sender, EventArgs e)
        {
            string maPhong = txtTimMaPhong.Text;

            List<RoomView> lstPhongSearch = GetRoomViewFromDB().Where(s => s.IDRoom.StartsWith(maPhong)
                                                     ).ToList();
            //Hiển thị lại dữ liệu trên datagridview
            gridDSP.DataSource = null;
            gridDSP.DataSource = lstPhongSearch;
        }
    }
}