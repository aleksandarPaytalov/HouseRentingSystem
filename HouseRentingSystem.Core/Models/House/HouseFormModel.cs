﻿using System.ComponentModel.DataAnnotations;
using HouseRentingSystem.Core.Constants;
using HouseRentingSystem.Infrastructure.Constants;

namespace HouseRentingSystem.Core.Models.House
{
	public class HouseFormModel
	{
		[Required(ErrorMessage = MessageConstants.RequiredMessage)]
		[StringLength(DataConstants.HouseTitleMaxLength,
			MinimumLength = DataConstants.HouseTitleMinLength,
			ErrorMessage = MessageConstants.LengthMessage)]
		public string Title { get; set; } = string.Empty;

		[Required(ErrorMessage = MessageConstants.RequiredMessage)]
		[StringLength(DataConstants.HouseAddressMaxLength,
			MinimumLength = DataConstants.HouseAddressMinLength,
			ErrorMessage = MessageConstants.LengthMessage)]
		public string Address { get; set; } = string.Empty;

		[Required(ErrorMessage = MessageConstants.RequiredMessage)]
		[StringLength(DataConstants.HouseDescriptionMaxLength,
			MinimumLength = DataConstants.HouseDescriptionMinLength,
			ErrorMessage = MessageConstants.LengthMessage)]
		public string Description { get; set; } = string.Empty;

		[Required(ErrorMessage = MessageConstants.RequiredMessage)]
		[Display(Name = "Image URL")]
		public string ImageUrl { get; set; } = string.Empty;

		[Required(ErrorMessage = MessageConstants.RequiredMessage)]
		[Range(typeof(decimal), DataConstants.HouseRentingPriceMinimum,
			DataConstants.HouseRentingPriceMaximum,
			ErrorMessage = "Price Per month must be positive number and greater than {2}")]
		public decimal PricePerMonth { get; set; }

		[Display(Name = "Category")]
		public int CategoryId { get; set; }

		public IEnumerable<HouseCategoryServiceModel> Categories { get; set; } = new List<HouseCategoryServiceModel>();
	}
}
