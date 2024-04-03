using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseRentingSystem.Core.Models.Admin.User;

namespace HouseRentingSystem.Core.Contracts
{
    public interface IUserService
    {
        Task<string> UserFullNameAsync(string userId);
        Task<IEnumerable<UserServiceModel>> AllAsync();
    }
}
