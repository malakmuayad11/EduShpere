namespace EduShpere.Data.Entities;

public partial class Section
{
    public int SectionId { get; set; }

    public int CourseId { get; set; }

    public string Title { get; set; } = null!;

    public byte SectionOrder { get; set; }

    public virtual Course Course { get; set; } = null!;

    public virtual ICollection<Lesson> Lessons { get; set; } = new List<Lesson>();
}
