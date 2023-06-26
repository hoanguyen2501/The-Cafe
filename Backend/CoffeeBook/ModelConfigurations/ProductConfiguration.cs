using CoffeeBook.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeBook.ModelConfigurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            #region Product

            builder.ToTable("Product")
                .HasKey(e => e.Id);
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd();

            builder.Property(e => e.Name)
                .HasMaxLength(150)
                .IsRequired()
                .IsUnicode();

            builder.Property(e => e.Description)
                .HasColumnType("text")
                .IsUnicode();

            builder.Property(e => e.Price)
                .HasDefaultValue(0);

            builder.Property(e => e.CreatedDate)
                .HasColumnType("date");

            builder.Property(e => e.Size)
                .HasDefaultValue(0);

            builder.HasOne<Supplier>(o => o.Supplier)
                .WithMany(m => m.Products)
                .HasForeignKey(fk => fk.SupplierId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne<ProductType>(o => o.ProductType)
                .WithMany(m => m.Products)
                .HasForeignKey(fk => fk.ProductTypeId)
                .OnDelete(DeleteBehavior.SetNull);

            #endregion Product
        }
    }
}