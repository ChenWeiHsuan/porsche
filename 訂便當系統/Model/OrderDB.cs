namespace 訂便當系統.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class OrderDB : DbContext
    {
        public OrderDB()
            : base("name=OrderDB")
        {
        }

        public virtual DbSet<Classroom> Classroom { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderDetail> OrderDetail { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Store> Store { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(e => e.Product_Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Store>()
                .HasMany(e => e.Order)
                .WithRequired(e => e.Store)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Store>()
                .HasMany(e => e.Product)
                .WithRequired(e => e.Store)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Order)
                .WithRequired(e => e.Student)
                .HasForeignKey(e => e.Store_Id)
                .WillCascadeOnDelete(false);
        }
    }
}
