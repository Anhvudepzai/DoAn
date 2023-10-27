namespace DoAnWinform.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoomBooking")]
    public partial class RoomBooking
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RoomBooking()
        {
            RoomBookingDetails = new HashSet<RoomBookingDetail>();
        }

        [Key]
        [StringLength(10)]
        public string IDRoomBooking { get; set; }

        public DateTime? DateOfBooking { get; set; }

        public DateTime? DateOfEnd { get; set; }
       
        public double? ToTal { get; set; }

        [StringLength(10)]
        public string IDRoom { get; set; }

        [StringLength(10)]
        public string IDEmployee { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Room Room { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoomBookingDetail> RoomBookingDetails { get; set; }
    }
}
