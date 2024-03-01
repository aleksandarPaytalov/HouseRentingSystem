using HouseRentingSystem.Attributes;
using HouseRentingSystem.Core.Constants;
using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Core.Models.Agent;
using HouseRentingSystem.Extensions;
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
		[NotAnAgent]
		public IActionResult Become()
		{
			var model = new BecomeAgentFormModel();

			return View(model);
		}

		[HttpPost]
		[NotAnAgent]
		public async Task<IActionResult> Become(BecomeAgentFormModel model)
		{
			if (await agentService.UserWithPhoneNumberExistAsync(model.PhoneNumber))
			{
				ModelState.AddModelError(nameof(model.PhoneNumber), MessageConstants.PhoneExists);
			}

			if (await agentService.UserHasRentsAsync(User.Id()))
			{
				ModelState.AddModelError("Error", MessageConstants.HasRents);
			}

			if (!ModelState.IsValid)
			{
				return View(model);
			}

			await agentService.CreateAsync(User.Id(), model.PhoneNumber);

			return RedirectToAction(nameof(HouseController.All), "House");
		}
	}
}
