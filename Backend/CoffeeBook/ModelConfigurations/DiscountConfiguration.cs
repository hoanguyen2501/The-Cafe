using CoffeeBook.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace CoffeeBook.ModelConfigurations
{
    public class DiscountConfiguration : IEntityTypeConfiguration<Discount>
    {
        public void Configure(EntityTypeBuilder<Discount> builder)
        {
            #region Discount

            builder.ToTable("Discount")
                .HasKey(e => e.Id);
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd();

            builder.Property(e => e.Name)
                .HasMaxLength(150)
                .IsRequired()
                .IsUnicode();

            builder.Property(e => e.Quantity)
                .HasDefaultValue(0);

            builder.Property(e => e.Value)
                .HasDefaultValue(0);

            builder.Property(e => e.MinPrice)
                .HasDefaultValue(0);

            builder.Property(e => e.ExpiredDate)
                .HasDefaultValue(DateTime.Parse("1/1/2021"));

            builder.Property(e => e.Photo)
                .HasMaxLength(250)
                .IsUnicode();

            #endregion Discount
        }
    }
}