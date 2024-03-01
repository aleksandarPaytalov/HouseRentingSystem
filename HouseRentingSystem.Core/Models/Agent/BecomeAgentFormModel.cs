
using System.ComponentModel.DataAnnotations;
using HouseRentingSystem.Core.Constants;
using HouseRentingSystem.Infrastructure.Constants;

namespace HouseRentingSystem.Core.Models.Agent
{
	public class BecomeAgentFormModel
	{
		[Required(ErrorMessage = MessageConstants.RequiredMessage)]
		[StringLength(DataConstants.AgentPhoneNumberMaxLength, 
			MinimumLength = DataConstants.AgentPhoneNumberMinLength,
			ErrorMessage = MessageConstants.LengthMessage)]
		[Display(Name = "Phone number")]
		[Phone]
		public string PhoneNumber { get; set; } = null!;
	}
}
