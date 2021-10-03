using ServisProgrami.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServisProgrami.Core.Repositories
{
    public interface IVehicleRepository:IRepository<Vehicle>
    {
        Task<Vehicle> GetWithCategoryByIdAsync(int vehicleId);



    }
}
