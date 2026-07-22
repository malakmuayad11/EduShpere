namespace EduShpere.Data.Entities;

public partial class User
{
    public int UserId { get; set; }

    public string Email { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = null!;

    /// <summary>
    /// 0 -&gt; Inactive, 1-&gt; Active.
    /// </summary>
    public bool IsActive { get; set; }

    public string? PhoneNumber { get; set; }

    public DateOnly DateOfBirth { get; set; }

    public virtual Admin? Admin { get; set; }

    public virtual Instructor? Instructor { get; set; }

    public virtual Student? Student { get; set; }

    public virtual ICollection<Token> Tokens { get; set; } = new List<Token>();
}
