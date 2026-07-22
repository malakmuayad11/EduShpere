namespace EduShpere.Infrastructure.DTOs.Admins
{
    public class AddAdminDto
    {
        public int UserID { get; set; }
        public string Email { get; set; } = null!;

        public string PasswordHash { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string? MiddleName { get; set; }
        public string LastName { get; set; } = null!;
        public bool IsActive { get; set; }
        public string? PhoneNumber { get; set; }
        public DateOnly DateOfBirth { get; set; }
    }
}
