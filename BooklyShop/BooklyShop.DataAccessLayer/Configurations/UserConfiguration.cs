using BooklyShop.BusinessObject.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooklyShop.DataAccessLayer.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("user");


            builder.Property(u => u.Email)
                   .IsRequired()
                     .HasMaxLength(255);
            builder.HasMany(u => u.Orders)
                   .WithOne(o => o.User)
                   .HasForeignKey(o => o.UserId)
                   .OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(u => u.Address)
                   .WithOne(a => a.User)
                   .HasForeignKey("UserId")
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(u => u.Transactions)
                   .WithOne(t => t.User)
                   .HasForeignKey("UserId")
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
