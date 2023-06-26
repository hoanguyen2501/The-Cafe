using CoffeeBook.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeBook.ModelConfigurations
{
    public class StoreConfiguration : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            #region Store

            builder.ToTable("Store")
                .HasKey(e => e.Id);
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd();

            builder.Property(e => e.StoreName)
                .HasMaxLength(150)
                .IsRequired()
                .IsUnicode();

            builder.Property(e => e.Description)
                .HasColumnType("text")
                .IsUnicode();

            builder.HasIndex(e => e.Address)
                .IsUnique();
            builder.Property(e => e.Address)
                .HasMaxLength(500)
                .IsRequired()
                .IsUnicode();

            builder.Property(e => e.Country)
                .HasMaxLength(100)
                .IsRequired()
                .IsUnicode();

            builder.HasIndex(e => e.Phone)
                .IsUnique();
            builder.Property(e => e.Phone)
                .HasMaxLength(11)
                .IsRequired();
            builder.Property(e => e.Photo)
               .HasColumnType("text")
                .IsUnicode();
            builder.Property(e => e.District)

                 .IsUnicode();

            builder.Property(e => e.LinkGG)
                .IsUnicode();

            builder.HasIndex(e => e.ManagerId)
                .IsUnique();

            builder.HasOne<Manager>(o => o.Manager)
                .WithOne(o => o.Store)
                .HasForeignKey<Store>(fk => fk.ManagerId)
                .OnDelete(DeleteBehavior.SetNull);

            #endregion Store
        }
    }
}