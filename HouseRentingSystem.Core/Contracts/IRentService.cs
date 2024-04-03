using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseRentingSystem.Core.Models.Admin;

namespace HouseRentingSystem.Core.Contracts
{
    public interface IRentService
    {
        Task<IEnumerable<RentServiceModel>> AllAsync();
    }
}
