namespace EduShpere.Data.Entities;

public partial class Instructor
{
    public int InstructorId { get; set; }

    public int UserId { get; set; }

    public virtual ICollection<InstructorsCourse> InstructorsCourses { get; set; } = new List<InstructorsCourse>();

    public virtual User User { get; set; } = null!;
}
