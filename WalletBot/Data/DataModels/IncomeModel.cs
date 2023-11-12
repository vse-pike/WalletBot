using System.ComponentModel.DataAnnotations;

namespace WalletBot.Data.DataModels;

public class IncomeModel
{
    [Key]
    public string IncomeId { get; set; }
    public string Name { get; set; }
    public ICollection<CommitModel> Commits { get; set; }
    public int CurrencyCode { get; set; }
    public string Type { get; set; }
    public DateOnly CreationDate { get; set; }
    public bool isArchived { get; set; }
    
    public string UserId { get; set; }
    public virtual UserModel User { get; set; }
}