using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Finmory.API.Models;

public class BudgetConfiguration : IEntityTypeConfiguration<Budget>
{
    public void Configure(EntityTypeBuilder<Budget> builder)
    {
        builder.HasOne(b => b.User)
            .WithMany(u => u.Budgets)
            .HasForeignKey(b => b.UserId);

        builder.HasOne(b => b.Category)
            .WithMany(c => c.Budgets)
            .HasForeignKey(b => b.CategoryId);
    }
}