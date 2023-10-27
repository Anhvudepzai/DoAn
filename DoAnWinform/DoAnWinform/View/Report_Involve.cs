namespace DoAnWinform.View
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Report_Involve
    {
        [Key]
        [StringLength(10)]
        public string IDCustomer { get; set; }

        [StringLength(50)]
        public string CustomerName { get; set; }

        [StringLength(50)]
        public string Gender { get; set; }

        [StringLength(10)]
        public string NumberPhone { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        public int? Quantity { get; set; }

        public double? Price { get; set; }

        [StringLength(50)]
        public string ServiceName { get; set; }

        public double? Expr1 { get; set; }

        public double? ToTal { get; set; }

        public DateTime? DateOfFounded { get; set; }
    }
}
