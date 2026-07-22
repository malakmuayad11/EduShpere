using EduShpere.Data.Entities;

namespace EduShpere.Repository.Interfaces
{
    public interface IAdminRepository
    {
        public Task<int?> AddAdminAsync(Admin admin);
    }
}
