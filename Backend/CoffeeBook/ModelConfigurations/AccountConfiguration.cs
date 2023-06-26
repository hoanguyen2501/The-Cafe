using CoffeeBook.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeBook.ModelConfigurations
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            #region Account

            builder.ToTable("Account")
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

            builder.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode();

            builder.Property(e => e.Avatar)
                .HasMaxLength(100);

            builder.HasOne<Role>(o => o.Role)
                .WithMany(m => m.Accounts)
                .HasForeignKey(fk => fk.RoleId)
                .OnDelete(DeleteBehavior.SetNull);

            #endregion Account
        }
    }
}