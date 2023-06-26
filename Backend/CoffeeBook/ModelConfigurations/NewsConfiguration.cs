using CoffeeBook.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeBook.ModelConfigurations
{
    public class NewsConfiguration : IEntityTypeConfiguration<News>
    {
        public void Configure(EntityTypeBuilder<News> builder)
        {
            #region News

            builder.ToTable("News")
                .HasKey(e => e.Id);
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd();

            builder.HasIndex(e => e.Title)
                .IsUnique();
            builder.Property(e => e.Title)
                .HasMaxLength(255)
                .IsRequired()
                .IsUnicode();

            builder.Property(e => e.Content)
                .HasColumnType("text")
                .IsUnicode();

            builder.Property(e => e.Thumbnail)
                .HasMaxLength(255)
                .IsUnicode();

            #endregion News
        }
    }
}