using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Core.Models.Agent;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem.Controllers
{
	[Authorize]
	public class AgentController : BaseController
	{
		private readonly IAgentService agentService;

		public AgentController(IAgentService _agentService)
		{
			this.agentService = _agentService;
		}

		[HttpGet]
		public async Task<IActionResult> Become()
		{
			var model = new BecomeAgentFormModel();
			return View(model);
		}

		public async Task<IActionResult> Become(BecomeAgentFormModel model)
		{
			return RedirectToAction(nameof(HouseController.All), "House");
		}
	}
}
