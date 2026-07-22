namespace EduShpere.Data.Entities;

public partial class Category
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}
