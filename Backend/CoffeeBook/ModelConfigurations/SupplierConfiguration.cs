using CoffeeBook.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeBook.ModelConfigurations
{
    public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            #region Supplier

            builder.ToTable("Supplier")
                .HasKey(e => e.Id);
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd();

            builder.Property(e => e.Name)
                .HasMaxLength(150)
                .IsRequired()
                .IsUnicode();

            builder.Property(e => e.Address)
                .HasColumnType("text")
                .IsRequired()
                .IsUnicode();

            builder.Property(e => e.City)
                .HasMaxLength(100)
                .IsRequired()
                .IsUnicode();

            builder.Property(e => e.Country)
                .HasMaxLength(100)
                .IsRequired()
                .IsUnicode();

            builder.HasIndex(e => e.Phone)
                .IsUnique();
            builder.Property(e => e.Phone)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(e => e.Url)
                .HasMaxLength(500)
                .IsRequired();

            #endregion Supplier
        }
    }
}