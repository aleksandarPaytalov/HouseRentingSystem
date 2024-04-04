using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Core.Models.Admin.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using static HouseRentingSystem.Core.Constants.AdministratorConstants;

namespace HouseRentingSystem.Areas.Admin.Controllers
{

    
    public class UserController : AdminBaseController
    {
        private readonly IUserService _userService;
        private readonly IMemoryCache _memoryCache;

        public UserController(IUserService userService,
	        IMemoryCache memoryCache)
        {
	        _userService = userService;
	        _memoryCache = memoryCache;
        }

        public async Task<IActionResult> All()
        {
	        var model = _memoryCache.Get<IEnumerable<UserServiceModel>>(UserCashKey);

	        if (model == null || model.Any() == false)
	        {
		        model = await _userService.AllAsync();
		        var cacheOptions = new MemoryCacheEntryOptions()
			        .SetAbsoluteExpiration(TimeSpan.FromMinutes(5));

		        _memoryCache.Set(UserCashKey, model, cacheOptions);
	        }

            return View(model);
        }
    }
}
