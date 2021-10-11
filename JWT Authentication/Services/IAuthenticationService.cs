using JWT_Authentication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWT_Authentication.Services
{
    public interface IAuthenticationService
    {
        Task<AuthenticationModel> RegisterAsync(RegisterModel registerModel);
        Task<AuthenticationModel> GetTokenAsync(TokenRequestModel model);
        Task<string> AddRoleAsync(AddRoleModel model);
    }
}
