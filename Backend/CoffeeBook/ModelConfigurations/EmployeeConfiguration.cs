using CoffeeBook.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeBook.ModelConfigurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            #region Employeee

            builder.ToTable("Employee")
                .HasKey(e => e.Id);
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd();

            builder.Property(e => e.Name)
                .HasMaxLength(150)
                .IsRequired()
                .IsUnicode();

            builder.Property(e => e.Age)
                .IsRequired();

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

            builder.Property(e => e.Address)
                .HasMaxLength(500)
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

            builder.Property(e => e.Salary)
                .HasDefaultValue(0);

            builder.Property(e => e.Status)
                .HasMaxLength(100)
                .HasDefaultValue("Hoạt động")
                .IsUnicode();

            builder.HasOne<Store>(o => o.Store)
                .WithMany(m => m.Employees)
                .HasForeignKey(fk => fk.StoreId)
                .OnDelete(DeleteBehavior.SetNull);

            #endregion Employeee
        }
    }
}