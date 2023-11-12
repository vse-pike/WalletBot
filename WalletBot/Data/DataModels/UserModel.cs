using System.ComponentModel.DataAnnotations;

namespace WalletBot.Data.DataModels;

public class UserModel
{
    [Key]
    public string UserId { get; set; }
    public string Name { get; set; }
    public ICollection<IncomeModel> Incomes { get; set; }
}