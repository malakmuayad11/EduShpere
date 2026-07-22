namespace EduShpere.Data.Entities;

public partial class Address
{
    public int AddressId { get; set; }

    public int StudentProfileId { get; set; }

    public byte? CountryId { get; set; }

    public string? City { get; set; }

    public string? StreetAddress { get; set; }

    public string? PostalCode { get; set; }

    public virtual Country? Country { get; set; }

    public virtual StudentProfile StudentProfile { get; set; } = null!;
}
