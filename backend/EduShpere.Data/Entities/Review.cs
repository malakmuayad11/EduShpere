namespace EduShpere.Data.Entities;

public partial class Review
{
    public int ReviewId { get; set; }

    public int EnrollmentId { get; set; }

    public byte Rate { get; set; }

    public string Content { get; set; } = null!;

    public DateOnly CreatedAt { get; set; }

    public virtual Enrollment Enrollment { get; set; } = null!;
}
