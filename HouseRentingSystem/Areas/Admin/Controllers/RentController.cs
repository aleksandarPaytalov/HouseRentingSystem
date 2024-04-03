using HouseRentingSystem.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem.Areas.Admin.Controllers
{
    public class RentController : AdminBaseController
    {
        private readonly IRentService _rentService;

        public RentController(IRentService rentService)
        {
            _rentService = rentService;
        }

        public async Task<IActionResult> All()
        {
            var model = await _rentService.AllAsync();

            return View(model);
        }
    }
}
