namespace EduShpere.Data.Entities;

public partial class Transaction
{
    public int TransactionId { get; set; }

    public int EnrollmentId { get; set; }

    public byte Status { get; set; }

    public int PaymentMethodId { get; set; }

    public DateOnly TransactionDate { get; set; }

    public virtual Enrollment Enrollment { get; set; } = null!;

    public virtual PaymentMethod PaymentMethod { get; set; } = null!;
}
