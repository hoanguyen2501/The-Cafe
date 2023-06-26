using CoffeeBook.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeBook.ModelConfigurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            #region Role

            builder.ToTable("Role")
                .HasKey(e => e.Id);
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd();

            builder.HasIndex(e => e.RoleName)
                .IsUnique();
            builder.Property(e => e.RoleName)
                .HasMaxLength(100)
                .IsRequired()
                .IsUnicode();

            builder.Property(e => e.Description)
                .HasColumnType("text")
                .IsUnicode();

            #endregion Role
        }
    }
}