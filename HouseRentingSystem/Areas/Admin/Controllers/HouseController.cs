using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Core.Models.Admin;
using HouseRentingSystem.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem.Areas.Admin.Controllers
{
	public class HouseController : AdminBaseController
	{
		private readonly IHouseService _houseService;
		private readonly IAgentService _agentService;

		public HouseController(IHouseService houseService, 
			IAgentService agentService)
		{
			_houseService = houseService;
			_agentService = agentService;
		}

		public async Task<IActionResult> Mine()
		{
			var userId = User.Id();
			int agentId = await _agentService.GetAgentIdAsync(userId) ?? 0;

			var myHouses = new MyHousesViewModel()
			{
				AddedHouses = await _houseService.AllHousesByAgentIdAsync(agentId),
				RentedHouses = await _houseService.AllHousesByUserId(userId)
			};

			return View(myHouses);
		}

		[HttpGet]
		public async Task<IActionResult> Approve()
		{
			var model = await _houseService.GetUnApprovedAsync();

			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Approve(int houseId)
		{
			await _houseService.ApproveHouseAsync(houseId);

			return RedirectToAction(nameof(Approve));
		}
	}
}
