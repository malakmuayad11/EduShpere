namespace EduShpere.Data.Entities;

public partial class InstructorsCourse
{
    public int InstructorsCoursesId { get; set; }

    public int InstructorId { get; set; }

    public int CourseId { get; set; }

    public virtual Course Course { get; set; } = null!;

    public virtual Instructor Instructor { get; set; } = null!;
}
