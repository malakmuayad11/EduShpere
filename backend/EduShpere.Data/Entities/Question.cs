namespace EduShpere.Data.Entities;

public partial class Question
{
    public int QuestionId { get; set; }

    public int QuizId { get; set; }

    public byte QuestionOrder { get; set; }

    public virtual ICollection<AnswerOption> AnswerOptions { get; set; } = new List<AnswerOption>();

    public virtual Quiz Quiz { get; set; } = null!;
}
