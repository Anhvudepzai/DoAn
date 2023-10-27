namespace DoAnWinform.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoomBookingDetail")]
    public partial class RoomBookingDetail
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string IDRoomBooking { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string IDCustomer { get; set; }

        public int? Quatity { get; set; }

        public double? Price { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual RoomBooking RoomBooking { get; set; }
    }
}
