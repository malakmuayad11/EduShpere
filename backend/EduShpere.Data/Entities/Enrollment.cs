namespace EduShpere.Data.Entities;

public partial class Enrollment
{
    public int EnrollmentId { get; set; }

    public int StudentId { get; set; }

    public int CourseId { get; set; }

    public DateOnly EnrollmentDate { get; set; }

    public virtual Certificate? Certificate { get; set; }

    public virtual Course Course { get; set; } = null!;

    public virtual Review? Review { get; set; }

    public virtual Student Student { get; set; } = null!;

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
