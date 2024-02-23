using System.Reflection.Metadata.Ecma335;
using HouseRentingSystem.Infrastructure.Data.Models;
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
            builder
                .Entity<House>()
                .HasOne(c => c.Category)
                .WithMany(c => c.Houses)
                .HasForeignKey(c => c.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<House>()
                .HasOne(a => a.Agent)
                .WithMany(a => a.Houses)
                .HasForeignKey(a => a.AgentId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(builder);
        }

        public DbSet<House> Houses { get; set; } = null!;

        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<Agent> Agents { get; set; } = null!;
    }
}