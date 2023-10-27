namespace DoAnWinform.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Price")]
    public partial class Price
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Price()
        {
            PriceDetails = new HashSet<PriceDetail>();
        }

        [Key]
        [StringLength(10)]
        public string IDPrice { get; set; }

        public DateTime? DateOfFounded { get; set; }

        public double? ToTal { get; set; }

        [StringLength(10)]
        public string IDCustomer { get; set; }

        [StringLength(10)]
        public string IDService { get; set; }
        public int Quantity { get; set; }
        public virtual Customer Customer { get; set; }

        public virtual Service Service { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PriceDetail> PriceDetails { get; set; }
    }
}
