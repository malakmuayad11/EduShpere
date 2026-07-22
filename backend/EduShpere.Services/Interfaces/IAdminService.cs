using EduShpere.Infrastructure.DTOs.Admins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduShpere.Services.Interfaces
{
    public interface IAdminService
    {
        public Task<int?> AddAdminAsync(AddAdminDto addAdminDto);
    }
}
