using HouseRentingSystem.Core.Services;
using HouseRentingSystem.Infrastructure.Data.Common;
using HouseRentingSystem.Infrastructure.Data.Models;

namespace Microsoft.Extensions.DependencyInjection;

using HouseRentingSystem.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using EntityFrameworkCore;
using HouseRentingSystem.Core.Contracts;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
	    services.AddScoped<IHouseService, HouseService>();
	    services.AddScoped<IAgentService, AgentService>();
	    services.AddScoped<IStatisticService, StatisticService>();

		return services;
    }

    public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration config)
    {
        var connectionString = config.GetConnectionString("DefaultConnection");
        services.AddDbContext<HouseRentingDbContext>(options =>
            options.UseSqlServer(connectionString));

        services.AddScoped<IRepository, Repository>();

        services.AddDatabaseDeveloperPageExceptionFilter();

        return services;
    }

    public static IServiceCollection AddApplicationIdentity(this IServiceCollection services, IConfiguration config)
    {
        services.AddDefaultIdentity<ApplicationUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;

            })
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<HouseRentingDbContext>();
        return services;
    }
}

