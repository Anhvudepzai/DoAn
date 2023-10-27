using DevExpress.XtraEditors;
using DoAnWinform.Model;
using DoAnWinform.Model.View;
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
    public partial class frmBooking : DevExpress.XtraEditors.XtraForm
    {
        public frmBooking()
        {
            InitializeComponent();
        }

        private void frmBooking_Load(object sender, EventArgs e)
        {
            fillRoom();
            fillCustomer();
            LoadGridViewData();
        }

        private void fillRoom()
        {
            HotelDbContext db = new HotelDbContext();
            List<Room> listroom = db.Rooms.ToList();
            cbbRoom.DataSource = listroom;
            cbbRoom.DisplayMember = "NumberOfRoom";
            cbbRoom.ValueMember = "IDRoom";
        }

        private void fillCustomer()
        {
            HotelDbContext db = new HotelDbContext();
            List<Customer> lcustomer = db.Customers.ToList();
            cbbKhachHang.DataSource = lcustomer;
            cbbKhachHang.DisplayMember = "CustomerName";
            cbbKhachHang.ValueMember = "IDCustomer";
        }
        private List<RoomBookingDetail> GetRoomBookingFromDB()
        {
            List<RoomBookingDetail> rb = new List<RoomBookingDetail>();
            HotelDbContext db = new HotelDbContext();
            rb = db.RoomBookingDetails.ToList();
            return rb;
        }
        private List<RoomBookingView> GetRoomBookingViewFromDB()
        {
            List<RoomBookingDetail> lrb = GetRoomBookingFromDB();
            return lrb.Select(s => new RoomBookingView
            {
                IDRoomBooking = s.IDRoomBooking,
                IDRoom = (int)s.RoomBooking.Room.NumberOfRoom,
                DateOfBooking = s.RoomBooking.DateOfBooking,
                DateOfEnd = s.RoomBooking.DateOfEnd,
                IDCustomer = s.Customer.CustomerName,
                Price = s.Price,
                ToTal = CalculateNumberOfDays(s.RoomBooking.DateOfBooking, s.RoomBooking.DateOfEnd) * s.Price
                
            }).ToList();
            
        }
        private void LoadGridViewData()
        {
            try
            {
                gridDSDP.DataSource = null;
                gridDSDP.DataSource = GetRoomBookingViewFromDB();
                List<RoomBookingDetail> rbk = new List<RoomBookingDetail>();

                if (gridDSDP.CurrentRow != null) // Kiểm tra xem có hàng được chọn không
                {
                    var chon = gridDSDP.CurrentRow;
                    string idroombooking = chon.Cells[0].Value?.ToString(); // Sử dụng ?.ToString() để xử lý giá trị null                  
                    string idroom = chon.Cells[1].Value?.ToString();
                    DateTime dateofbooking = chon.Cells[2].Value as DateTime? ?? DateTime.MinValue; // Sử dụng toán tử as để xử lý giá trị null
                    DateTime dateofend = chon.Cells[3].Value as DateTime? ?? DateTime.MinValue;
                    string idcustomer = chon.Cells[4].Value?.ToString();
                    string price = chon.Cells[5].Value?.ToString();
                    string total = chon.Cells[6].Value?.ToString();
                    txtMaDP.Text = idroombooking;
                    cbbRoom.Text = idroom;
                    cbbKhachHang.Text = idcustomer;
                    txtGia.Text = price;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    

        private void btnDP_Click(object sender, EventArgs e)
        {
            try
            {
                HotelDbContext db = new HotelDbContext();
                RoomBooking checkExit = db.RoomBookings.Find(txtMaDP.Text);
                if (checkExit != null)
                {
                    MessageBox.Show("Mã phòng đã tồn tại");
                }
                else
                {
                    RoomBooking rb = new RoomBooking();
                    
                    rb.IDRoomBooking = txtMaDP.Text;
                    rb.Room.IDRoom = cbbRoom.SelectedValue.ToString();
                    rb.DateOfBooking = DateTime.Parse(dtpNgayDat.Text);
                    rb.DateOfEnd = DateTime.Parse(dtpNgayTra.Text);
                  
                    bool isRoomAvailable = IsRoomAvailable(rb.IDRoom, rb.DateOfEnd, rb.DateOfEnd);

                    if (isRoomAvailable)
                    {
                        db.RoomBookings.Add(rb);
                        db.SaveChanges();
                        LoadGridViewData();
                        MessageBox.Show("Đặt phòng thành công  ");
                    }
                    else
                    {
                        MessageBox.Show("Phòng đã được đặt");
                    }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message.ToString());
            }
        }
        private bool IsRoomAvailable(string roomID, DateTime? startDate, DateTime? endDate)
        {
            using (var dbContext = new HotelDbContext())
            {
                bool isRoomBooked = dbContext.RoomBookingDetails
               .Any(booking => booking.RoomBooking.IDRoom == roomID &&
                               ((booking.RoomBooking.DateOfBooking >= startDate && booking.RoomBooking.DateOfBooking <= endDate) ||
                                (booking.RoomBooking.DateOfEnd >= startDate && booking.RoomBooking.DateOfEnd <= endDate) ||
                                (booking.RoomBooking.DateOfBooking <= startDate && booking.RoomBooking.DateOfEnd >= endDate)));

                return !isRoomBooked;
            }

        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            HotelDbContext dbContext = new HotelDbContext();
            var RoomDelete = dbContext.RoomBookings.Find(txtMaDP.Text);
            if (RoomDelete != null)
            {
                dbContext.RoomBookings.Remove(RoomDelete);
                dbContext.SaveChanges();
            }
            else
            {
                MessageBox.Show("Không tìm thấy phòng cần xóa");
            }

            LoadGridViewData();
        }
        private int CalculateNumberOfDays(DateTime? dateOfStart, DateTime? dateOfEnd)
        {
            if (dateOfStart.HasValue && dateOfEnd.HasValue)
            {
                TimeSpan duration = dateOfEnd.Value.Subtract(dateOfStart.Value);
                int numberOfDays = duration.Days + 1;

                return numberOfDays;
            }

            return 0;
        }

        private void gridDSDP_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (gridDSDP.CurrentRow != null) // Kiểm tra xem có hàng được chọn không
            {
                var chon = gridDSDP.CurrentRow;
                string idroombooking = chon.Cells[0].Value?.ToString(); // Sử dụng ?.ToString() để xử lý giá trị null                  
                string idroom = chon.Cells[1].Value?.ToString();
                DateTime dateofbooking = chon.Cells[2].Value as DateTime? ?? DateTime.MinValue; // Sử dụng toán tử as để xử lý giá trị null
                DateTime dateofend = chon.Cells[3].Value as DateTime? ?? DateTime.MinValue;
                string idcustomer = chon.Cells[4].Value?.ToString();
                string price = chon.Cells[5].Value?.ToString();
                string total = chon.Cells[6].Value?.ToString();
                txtMaDP.Text = idroombooking;
                cbbRoom.Text = idroom;
                cbbKhachHang.Text = idcustomer;
                txtGia.Text = price;
            }
        }
    }
        
 }
