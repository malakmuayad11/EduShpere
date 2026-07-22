namespace EduShpere.Data.Entities;

public partial class Certificate
{
    public int CertificateId { get; set; }

    public int EnrollmentId { get; set; }

    public DateOnly IssueDate { get; set; }

    public virtual Enrollment Enrollment { get; set; } = null!;
}
