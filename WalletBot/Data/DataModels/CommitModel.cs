using System.ComponentModel.DataAnnotations;

namespace WalletBot.Data.DataModels;

public class CommitModel
{
    [Key]
    public string CommitId { get; set; }
    public Decimal Value { get; set; }
    public DateOnly AddedDate { get; set; }
    
    public string IncomeId { get; set; }
    public virtual IncomeModel Income { get; set; }
    
}