﻿using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Core.Services;
using HouseRentingSystem.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace HouseRentingSystem.Attributes
{
	public class NotAnAgentAttribute : ActionFilterAttribute
	{
		public override void OnActionExecuting(ActionExecutingContext context)
		{
			IAgentService? agentService = context.HttpContext.RequestServices.GetService<AgentService>();

			if (agentService == null)
			{
				context.Result = new StatusCodeResult(StatusCodes.Status500InternalServerError);
			}

			if (agentService != null && agentService.ExistByIdAsync(context.HttpContext.User.Id()).Result)
			{
				context.Result = new StatusCodeResult(StatusCodes.Status400BadRequest);
			}
		}
	}
}
