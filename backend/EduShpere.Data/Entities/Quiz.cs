namespace EduShpere.Data.Entities;

public partial class Quiz
{
    public int QuizId { get; set; }

    public int LessonId { get; set; }

    public string Title { get; set; } = null!;

    public virtual Lesson Lesson { get; set; } = null!;

    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();
}
