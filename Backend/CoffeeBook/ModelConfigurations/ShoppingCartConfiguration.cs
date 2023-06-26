using CoffeeBook.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace CoffeeBook.ModelConfigurations
{
    public class ShoppingCartConfiguration : IEntityTypeConfiguration<ShoppingCart>
    {
        public void Configure(EntityTypeBuilder<ShoppingCart> builder)
        {
            #region ShoppingCart

            builder.ToTable("ShoppingCart").
                HasKey(e => e.Id);
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd();

            builder.Property(e => e.ProductQuantity)
                .IsRequired()
                .HasDefaultValue(0);

            builder.Property(e => e.CreatedDate)
                .HasDefaultValue(DateTime.Now);

            builder.HasOne<Customer>(o => o.Customer)
                .WithMany(m => m.ShoppingCarts)
                .HasForeignKey(fk => fk.CustomerId)
                .OnDelete(DeleteBehavior.SetNull);

            #endregion ShoppingCart
        }
    }
}