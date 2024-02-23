using System.ComponentModel.DataAnnotations;
using HouseRentingSystem.Infrastructure.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem.Infrastructure.Data.Models
{
    [Comment("House Agent")]
    public class Agent
    {
        [Key]
        [Comment("Agent Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(DataConstants.AgentPhoneNumberMaxLength)]
        [Comment("Agent phone number")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        [Comment("User identifier")]
        public string UserId { get; set; } = string.Empty;

        public IdentityUser User { get; set; } = null!;

        public ICollection<House> Houses { get; set; } = new List<House>();

    }
}
