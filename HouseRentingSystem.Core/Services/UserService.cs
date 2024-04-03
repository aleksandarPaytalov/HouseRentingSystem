using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Core.Models.Admin.User;
using HouseRentingSystem.Infrastructure.Data.Common;
using HouseRentingSystem.Infrastructure.Migrations;
using Microsoft.EntityFrameworkCore;
using ApplicationUser = HouseRentingSystem.Infrastructure.Data.Models.ApplicationUser;

namespace HouseRentingSystem.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository _repository;

        public UserService(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<string> UserFullNameAsync(string userId)
        {
            string result = string.Empty;
            var user = await _repository.GetByIdAsync<ApplicationUser>(userId);

            if (user != null)
            {
                result = $"{user.FirstName} {user.LastName}";
            }

            return result;
        }

        public async Task<IEnumerable<UserServiceModel>> AllAsync()
        {
            return await _repository.AllReadOnly<ApplicationUser>()
                .Include(u => u.Agent)
                .Select(u => new UserServiceModel()
                {
                    Email = u.Email,
                    FullName = $"{u.FirstName} {u.LastName}",
                    PhoneNumber = u.Agent != null ? u.Agent.PhoneNumber : null,
                    IsAgent = u.Agent != null
                })
                .ToListAsync();
        }
    }
}
