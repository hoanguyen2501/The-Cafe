using CoffeeBook.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeBook.ModelConfigurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            #region Customer

            builder.ToTable("Customer")
                .HasKey(e => e.Id);
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd();

            builder.HasIndex(e => e.Username)
                .IsUnique();
            builder.Property(e => e.Username)
                .HasMaxLength(100)
                .IsRequired()
                .IsUnicode(false);

            builder.Property(e => e.Password)
                .HasMaxLength(100)
                .IsRequired()
                .IsUnicode(false);

            builder.HasIndex(e => e.Email)
                .IsUnique();
            builder.Property(e => e.Email)
                .HasMaxLength(100)
                .IsRequired()
                .IsUnicode(false);

            builder.HasIndex(e => e.Phone)
                .IsUnique();
            builder.Property(e => e.Phone)
                .HasMaxLength(11)
                .IsRequired();

            builder.Property(e => e.Name)
                .HasMaxLength(100)
                .IsRequired()
                .IsUnicode();

            builder.Property(e => e.Avata)
                .HasMaxLength(255);

            builder.Property(e => e.Address)
                .HasColumnType("text")
                .IsUnicode();

            builder.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode();

            builder.Property(e => e.Country)
                .HasMaxLength(100)
                .IsUnicode();

            #endregion Customer
        }
    }
}