namespace DoAnWinform.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PriceDetail")]
    public partial class PriceDetail
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string IDEmployee { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string IDPrice { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Price Price1 { get; set; }
    }
}
