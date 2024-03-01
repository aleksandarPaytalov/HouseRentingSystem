using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Infrastructure.Common;
using HouseRentingSystem.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem.Core.Services
{
	public class AgentService : IAgentService
	{
		private readonly IRepository repository;

		public AgentService(IRepository _repository)
		{
			this.repository = _repository;
		}

		public async Task<bool> ExistByIdAsync(string userId)
		{
			return await repository.AllReadOnly<Agent>()
				.AnyAsync(a => a.UserId == userId);
		}

		public Task<bool> UserWithPhoneNumberExistAsync(string phoneNumber)
		{
			throw new NotImplementedException();
		}

		public Task<bool> UserHAsRentsAsync(string userId)
		{
			throw new NotImplementedException();
		}

		public Task CreateAsync(string userId, string phoneNumber)
		{
			throw new NotImplementedException();
		}
	}
}
