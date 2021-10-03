using ServisProgrami.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServisProgrami.Core.Service
{
    public interface IVehicleService:IService<Vehicle>
    {
        Task<Vehicle> GetWithByVehicleIdAsync(int vehicleId);
    }
}
