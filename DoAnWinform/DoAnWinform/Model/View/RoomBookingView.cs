using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWinform.Model.View
{
    public class RoomBookingView
    {
        public string IDRoomBooking { get; set; }
        public int IDRoom { get; set; }
        public DateTime? DateOfBooking { get; set; }
        public DateTime? DateOfEnd { get; set; }
        public string IDCustomer { get; set; }
        public double? Price { get; set; }
        public double? ToTal { get; set; }
    }
}
