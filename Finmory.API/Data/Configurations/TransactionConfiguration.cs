using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Finmory.API.Models;

public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
{
    public void Configure(EntityTypeBuilder<Transaction> builder)
    {
        builder.HasOne(t => t.User)
            .WithMany(u => u.Transactions)
            .HasForeignKey(t => t.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(t => t.Category)
            .WithMany(c => c.Transactions)
            .HasForeignKey(t => t.CategoryId);

        builder.HasOne(t => t.Subcategory)
            .WithMany(sc => sc.Transactions)
            .HasForeignKey(t => t.SubcategoryId)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasOne(t => t.FinancialAccount)
            .WithMany(fa => fa.Transactions)
            .HasForeignKey(t => t.FinancialAccountId);
    }
}