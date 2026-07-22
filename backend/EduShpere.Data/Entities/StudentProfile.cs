namespace EduShpere.Data.Entities;

public partial class StudentProfile
{
    public int StudentProfileId { get; set; }

    public int StudentId { get; set; }

    public string? ImageUrl { get; set; }

    public string? About { get; set; }

    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();

    public virtual Student Student { get; set; } = null!;
}
