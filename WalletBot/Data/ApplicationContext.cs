using Microsoft.EntityFrameworkCore;
using WalletBot.Data.DataModels;

namespace WalletBot.Data;

public class ApplicationContext: DbContext
{
    public DbSet<UserModel> Users { get; set; } = null!;
    public DbSet<IncomeModel> Incomes { get; set; } = null!;
    public DbSet<CommitModel> Commits { get; set; } = null!;
    
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserModel>()
            .HasMany(e => e.Incomes)
            .WithOne(e => e.User)
            .HasForeignKey(e => e.UserId)
            .IsRequired();
        
        modelBuilder.Entity<IncomeModel>()
            .HasMany(e => e.Commits)
            .WithOne(e => e.Income)
            .HasForeignKey(e => e.IncomeId)
            .IsRequired();

        base.OnModelCreating(modelBuilder);
    }

}