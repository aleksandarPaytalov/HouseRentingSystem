using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HouseRentingSystem.Infrastructure.Constants;
using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem.Infrastructure.Data.Models
{
    [Comment("House")]
    public class House
    {
        [Key]
        [Comment("House identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(DataConstants.HouseTitleMaxLength)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MaxLength(DataConstants.HouseAddressMaxLength)]
        [Comment("House address")]
        public string Address { get; set; } = string.Empty;

        [Required]
        [MaxLength(DataConstants.HouseDescriptionMaxLength)]
        [Comment("House description")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Comment("House image url")]
        public string ImageUrl { get; set; } = string.Empty;

        [Required]
        [Comment("House price per month")]
        [Column(TypeName = "decimal(18,2)")]
        //[Range(typeof(decimal), 
        //    DataConstants.HouseRentingPriceMinimum,
        //    DataConstants.HouseRentingPriceMaximum,
        //    ConvertValueInInvariantCulture = true)]
        public decimal PricePerMonth { get; set; }

        [Required]
        [Comment("Category identifier")]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))] 
        public Category Category { get; set; } = null!;

        [Required]
        [Comment("Agent identifier")]
        public int AgentId { get; set; }

        [ForeignKey(nameof(AgentId))] 
        public Agent Agent { get; set; } = null!;

        [Comment("User id of the rent agent")]
        public string? RenterId { get; set; }
    }
}
