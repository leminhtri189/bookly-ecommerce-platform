using BooklyShop.BusinessObject.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooklyShop.DataAccessLayer.Context
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        public DbSet<Books> Books { get; set; }
        public DbSet<BookImages> BookImages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDBContext).Assembly);


            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                if (typeof(BaseModel).IsAssignableFrom(entityType.ClrType))
                {
                    var entity = modelBuilder.Entity(entityType.ClrType);
                    entity.HasKey(nameof(BaseModel.Id));

                    entity.Property(nameof(BaseModel.Id))
                          .HasColumnName("id")
                          .ValueGeneratedOnAdd();

                    entity.Property(nameof(BaseModel.CreatedAt))
                          .HasColumnName("created_at")
                          .HasDefaultValueSql("GETUTCDATE()");

                    entity.Property(nameof(BaseModel.UpdatedAt))
                          .HasColumnName("updated_at")
                          .HasDefaultValueSql("GETUTCDATE()");

                    entity.Property(nameof(BaseModel.IsDeleted))
                          .HasColumnName("is_deleted")
                          .HasDefaultValue(false);
                }
            }
            base.OnModelCreating(modelBuilder);
        }
    }
}
