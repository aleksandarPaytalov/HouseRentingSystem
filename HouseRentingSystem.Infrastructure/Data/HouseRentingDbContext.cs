﻿using HouseRentingSystem.Infrastructure.Data.Models;
using HouseRentingSystem.Infrastructure.Data.SeedDb;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem.Infrastructure.Data
{
    public class HouseRentingDbContext : IdentityDbContext
    {
        public HouseRentingDbContext(DbContextOptions<HouseRentingDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new HouseConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new AgentConfiguration());

            base.OnModelCreating(builder);
        }

        public DbSet<House> Houses { get; set; } = null!;

        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<Agent> Agents { get; set; } = null!;
    }
}