using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DoAnWinform.View
{
    public partial class PriceReport : DbContext
    {
        public PriceReport()
            : base("name=PriceReport")
        {
        }

        public virtual DbSet<Report_Involve> Report_Involve { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Report_Involve>()
                .Property(e => e.IDCustomer)
                .IsFixedLength();

            modelBuilder.Entity<Report_Involve>()
                .Property(e => e.NumberPhone)
                .IsFixedLength();
        }
    }
}
