using BooklyShop.BusinessObject.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooklyShop.DataAccessLayer.Configurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("address");
            builder.Property(a => a.Location)
                .   HasColumnName("location")
                   .IsRequired()
                   .HasMaxLength(255);

            builder.Property(a => a.UserId)
                .   HasColumnName("user_id")
                   .IsRequired();

            builder.HasOne(a => a.User)
                   .WithMany(u => u.Address)
                   .HasForeignKey("UserId")
                   .OnDelete(DeleteBehavior.Cascade);
        }
    
    }
}
