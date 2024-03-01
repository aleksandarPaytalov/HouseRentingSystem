﻿using HouseRentingSystem.Core.Contracts.House;
using HouseRentingSystem.Core.Models.Home;
using HouseRentingSystem.Infrastructure.Common;
using HouseRentingSystem.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem.Core.Services
{
	public class HouseService : IHouseService
	{
		private readonly IRepository repository;

		public HouseService(IRepository _repository)
		{
			this.repository = _repository;
		}

		public async Task<IEnumerable<HouseIndexServiceModel>> LastThreeHouses()
		{
			return await repository
				.AllReadOnly<House>()
				.OrderByDescending(h => h.Id)
				.Take(3)
				.Select(h => new HouseIndexServiceModel()
				{
					Id = h.Id,
					ImageUrl = h.ImageUrl,
					Title = h.Title

				})
				.ToListAsync();
		}
	}
}