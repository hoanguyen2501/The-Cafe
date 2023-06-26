using CoffeeBook.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace CoffeeBook.ModelConfigurations
{
    public class BillConfiguration : IEntityTypeConfiguration<Bill>
    {
        public void Configure(EntityTypeBuilder<Bill> builder)
        {
            #region Bill

            builder.ToTable("Bill")
                .HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd();

            builder.Property(e => e.Validated)
                .HasDefaultValue(0);

            builder.Property(e => e.Status)
                .HasMaxLength(100)
                .HasDefaultValue("Đang chờ thanh toán")
                .IsUnicode();

            builder.Property(e => e.Name)
                .IsRequired()
                .IsUnicode();

            builder.Property(e => e.Address)
                .IsRequired()
                .IsUnicode();

            builder.Property(e => e.PayBy)
                .IsRequired()
                .IsUnicode();

            builder.Property(e => e.Phone)
                .IsRequired()
                .IsUnicode();

            builder.Property(e => e.Time)
                .HasMaxLength(100)
                .HasDefaultValue("15 - 20 phút")
                .IsUnicode();

            builder.Property(e => e.Note)
                .IsUnicode();

            builder.Property(e => e.CreatedDate)
                .HasDefaultValue(DateTime.Now);

            builder.HasOne<Customer>(o => o.Customer)
                .WithMany(m => m.Bills)
                .HasForeignKey(fk => fk.CustomerId)
                .OnDelete(DeleteBehavior.SetNull);

            #endregion Bill
        }
    }
}