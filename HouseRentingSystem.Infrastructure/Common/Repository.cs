﻿using HouseRentingSystem.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem.Infrastructure.Common
{
	public class Repository : IRepository
	{
		private readonly DbContext context;

		public Repository(HouseRentingDbContext _context)
		{
			context = _context;
		}

		private DbSet<T> Dbset<T>() where T : class
		{
			return context.Set<T>();
		}


		public IQueryable<T> All<T>() where T : class
		{
			return Dbset<T>();
		}

		public IQueryable<T> AllReadOnly<T>() where T : class
		{
			return Dbset<T>()
				.AsNoTracking();
		}
	}
}