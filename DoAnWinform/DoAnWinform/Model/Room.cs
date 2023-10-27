namespace DoAnWinform.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Room")]
    public partial class Room
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Room()
        {
            RoomBookings = new HashSet<RoomBooking>();
        }

        [Key]
        [StringLength(10)]
        public string IDRoom { get; set; }

        public int? NumberOfRoom { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [StringLength(10)]
        public string IDRoomType { get; set; }

        public virtual RoomType RoomType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoomBooking> RoomBookings { get; set; }
    }
}
