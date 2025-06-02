using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Finmory.API.Models;

public class FinancialAccountConfiguration : IEntityTypeConfiguration<FinancialAccount>
{
    public void Configure(EntityTypeBuilder<FinancialAccount> builder)
    {
        builder.HasOne(f => f.User)
            .WithMany(u => u.FinancialAccounts)
            .HasForeignKey(f => f.UserId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}