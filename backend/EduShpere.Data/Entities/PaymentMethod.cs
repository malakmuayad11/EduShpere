namespace EduShpere.Data.Entities;

public partial class PaymentMethod
{
    public int PaymentMethodId { get; set; }

    public string PaymentMethodName { get; set; } = null!;

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
