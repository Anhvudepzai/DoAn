using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DoAnWinform.Model
{
    public partial class HotelDbContext : DbContext
    {
        public HotelDbContext()
            : base("name=HotelDbContext1")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Price> Prices { get; set; }
        public virtual DbSet<PriceDetail> PriceDetails { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<RoomBooking> RoomBookings { get; set; }
        public virtual DbSet<RoomBookingDetail> RoomBookingDetails { get; set; }
        public virtual DbSet<RoomType> RoomTypes { get; set; }
        public virtual DbSet<Service> Services { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.IDCustomer)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.NumberPhone)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.RoomBookingDetails)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.IDEmployee)
                .IsFixedLength();

            modelBuilder.Entity<Employee>()
                .Property(e => e.PhoneNumber)
                .IsFixedLength();

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.PriceDetails)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Price>()
                .Property(e => e.IDPrice)
                .IsFixedLength();

            modelBuilder.Entity<Price>()
                .Property(e => e.IDCustomer)
                .IsFixedLength();

            modelBuilder.Entity<Price>()
                .Property(e => e.IDService)
                .IsFixedLength();

            modelBuilder.Entity<Price>()
                .HasMany(e => e.PriceDetails)
                .WithRequired(e => e.Price1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PriceDetail>()
                .Property(e => e.IDEmployee)
                .IsFixedLength();

            modelBuilder.Entity<PriceDetail>()
                .Property(e => e.IDPrice)
                .IsFixedLength();

            modelBuilder.Entity<Room>()
                .Property(e => e.IDRoom)
                .IsFixedLength();

            modelBuilder.Entity<Room>()
                .Property(e => e.IDRoomType)
                .IsFixedLength();

            modelBuilder.Entity<RoomBooking>()
                .Property(e => e.IDRoomBooking)
                .IsFixedLength();

            modelBuilder.Entity<RoomBooking>()
                .Property(e => e.IDRoom)
                .IsFixedLength();

            modelBuilder.Entity<RoomBooking>()
                .Property(e => e.IDEmployee)
                .IsFixedLength();

            modelBuilder.Entity<RoomBooking>()
                .HasMany(e => e.RoomBookingDetails)
                .WithRequired(e => e.RoomBooking)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RoomBookingDetail>()
                .Property(e => e.IDRoomBooking)
                .IsFixedLength();

            modelBuilder.Entity<RoomBookingDetail>()
                .Property(e => e.IDCustomer)
                .IsFixedLength();

            modelBuilder.Entity<RoomType>()
                .Property(e => e.IDRoomType)
                .IsFixedLength();

            modelBuilder.Entity<Service>()
                .Property(e => e.IDService)
                .IsFixedLength();
        }
    }
}
