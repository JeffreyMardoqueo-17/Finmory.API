using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Finmory.API.Models;

namespace Finmory.API.Data.Configurations
{
    public class SubcategoryConfiguration : IEntityTypeConfiguration<Subcategory>
    {
        public void Configure(EntityTypeBuilder<Subcategory> builder)
        {
            builder.HasKey(sc => sc.Id);

            builder.Property(sc => sc.Name)
                .IsRequired()
                .HasMaxLength(100);

            // builder.Property(sc => sc.Description)
            //     .HasMaxLength(500);

            // Relación 1:N con Transactions
            builder.HasMany(sc => sc.Transactions)
                .WithOne(t => t.Subcategory)
                .HasForeignKey(t => t.SubcategoryId)
                .OnDelete(DeleteBehavior.SetNull);

            // Relación N:1 con Category
            builder.HasOne(sc => sc.Category)
                .WithMany(c => c.Subcategories)
                .HasForeignKey(sc => sc.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
