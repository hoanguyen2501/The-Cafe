using CoffeeBook.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeBook.ModelConfigurations
{
    public class ProductTypeConfiguration : IEntityTypeConfiguration<ProductType>
    {
        public void Configure(EntityTypeBuilder<ProductType> builder)
        {
            #region ProductType

            builder.ToTable("ProductType")
                .HasKey(e => e.Id);
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd();

            builder.HasIndex(e => e.Name)
                .IsUnique();
            builder.Property(e => e.Name)
                .HasMaxLength(150)
                .IsRequired()
                .IsUnicode();

            builder.Property(e => e.Description)
                .HasColumnType("text")
                .IsUnicode();

            #endregion ProductType
        }
    }
}