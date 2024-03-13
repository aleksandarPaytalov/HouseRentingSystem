using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseRentingSystem.Core.Models.Agent;

namespace HouseRentingSystem.Core.Models.House
{
    public class HouseDetailsServiceModel : HouseServiceModel
    {
        public string Description { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public AgentServiceModel Agent { get; set; } = null!; 
    }
}
