namespace EduShpere.Data.Entities;

public partial class AnswerOption
{
    public int AnswerOptionId { get; set; }

    public int QuestionId { get; set; }

    public string Content { get; set; } = null!;

    public bool IsCorrect { get; set; }

    public byte AnswerOptionOrder { get; set; }

    public virtual Question Question { get; set; } = null!;
}
