using CoffeeBook.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace CoffeeBook.ModelConfigurations
{
    public class ShoppingCartProductConfiguration : IEntityTypeConfiguration<ShoppingCart_Product>
    {
        public void Configure(EntityTypeBuilder<ShoppingCart_Product> builder)
        {
            #region ShoppingCart_Product

            builder.ToTable("ShoppingCart_Product")
                .HasKey(e => new { e.ShoppingCartId, e.ProductId });

            builder.Property(e => e.Count)
                .HasDefaultValue(0);

            builder.Property(e => e.TilteSize)
                .HasMaxLength(100)
                .HasDefaultValue("Nhỏ")
                .IsUnicode();

            builder.Property(e => e.CreatedDate)
                .HasDefaultValue(DateTime.Now);

            builder.HasOne<ShoppingCart>(o => o.ShoppingCart)
                .WithMany(m => m.ShoppingCart_Products)
                .HasForeignKey(fk => fk.ShoppingCartId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne<Product>(o => o.Product)
                .WithMany(m => m.ShoppingCart_Products)
                .HasForeignKey(fk => fk.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            #endregion ShoppingCart_Product
        }
    }
}