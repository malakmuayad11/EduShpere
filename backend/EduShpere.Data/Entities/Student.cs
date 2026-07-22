namespace EduShpere.Data.Entities;

public partial class Student
{
    public int StudentId { get; set; }

    public int UserId { get; set; }

    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

    public virtual StudentProfile? StudentProfile { get; set; }

    public virtual User User { get; set; } = null!;
}
