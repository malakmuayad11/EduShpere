using EduShpere.Data;
using EduShpere.Data.Entities;
using EduShpere.Repository.Interfaces;

namespace EduShpere.Repository.Classes
{
    public class AdminRepository : IAdminRepository
    {
        private readonly EduShpereContext _context;

        public AdminRepository(EduShpereContext context)
        {
            _context = context;
        }
        public async Task<int?> AddAdminAsync(Admin admin)
        {
            if(admin == null || admin.User == null) return null;

            await _context.Users.AddAsync(admin.User);

            if(await _context.SaveChangesAsync() > 0)
            {
                await _context.Admins.AddAsync(admin);
                if(await _context.SaveChangesAsync() > 0)
                {
                    return admin.AdminId;
                }
            }

            return null;
        }
    }
}
