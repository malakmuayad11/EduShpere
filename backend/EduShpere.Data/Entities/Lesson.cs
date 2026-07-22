namespace EduShpere.Data.Entities;

public partial class Lesson
{
    public int LessonId { get; set; }

    public int SectionId { get; set; }

    public string Title { get; set; } = null!;

    public byte LessonOrder { get; set; }

    /// <summary>
    /// 0 -&gt; Not protected, 1 -&gt; Protected
    /// </summary>
    public bool IsProtected { get; set; }

    public string? VideoUrl { get; set; }

    public string? TextContent { get; set; }

    public virtual ICollection<Quiz> Quizzes { get; set; } = new List<Quiz>();

    public virtual Section Section { get; set; } = null!;
}
