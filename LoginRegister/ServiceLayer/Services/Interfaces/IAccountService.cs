using ServiceLayer.DTOs.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IAccountService
    {
        Task<string?> LoginAsync(LoginDto model);
        Task<ApiResponse> RegisterAsync(RegisterDto model);
        Task CreateRoleAsync(RoleDto model);
    }
}
