namespace EduShpere.Data.Entities;

public partial class Course
{
    public int CourseId { get; set; }

    public int CategoryId { get; set; }

    public string Title { get; set; } = null!;

    public decimal Price { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string ImageUrl { get; set; } = null!;

    public string? Description { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

    public virtual ICollection<InstructorsCourse> InstructorsCourses { get; set; } = new List<InstructorsCourse>();

    public virtual ICollection<Section> Sections { get; set; } = new List<Section>();
}
