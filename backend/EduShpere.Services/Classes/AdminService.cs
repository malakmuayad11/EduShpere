using EduShpere.Data.Entities;
using EduShpere.Infrastructure.DTOs.Admins;
using EduShpere.Repository.Interfaces;
using EduShpere.Services.Interfaces;

namespace EduShpere.Services.Classes
{
    public class AdminService : IAdminService
    {
        private IAdminRepository _adminRepository;

        public AdminService(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }
           
        public async Task<int?> AddAdminAsync(AddAdminDto addAdminDto)
        {
            if (addAdminDto == null) return null;
            Admin admin = new Admin
            {
                User = new User
                {
                    FirstName = addAdminDto.FirstName,
                    LastName = addAdminDto.LastName,
                    Email = addAdminDto.Email,
                    PasswordHash = addAdminDto.PasswordHash
                }
            };
            if (await _adminRepository.AddAdminAsync(admin) > 0) return admin.AdminId;
            
            return null;
        }
    }
}
