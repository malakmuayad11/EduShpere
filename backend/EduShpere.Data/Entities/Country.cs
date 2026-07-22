namespace EduShpere.Data.Entities;

public partial class Country
{
    public byte CountryId { get; set; }

    public string? CountryName { get; set; }

    public virtual Address? Address { get; set; }
}
