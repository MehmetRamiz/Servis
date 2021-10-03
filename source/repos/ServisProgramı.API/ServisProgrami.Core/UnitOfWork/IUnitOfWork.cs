using ServisProgrami.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServisProgrami.Core.UnitOfWork
{
    public interface IUnitOfWork
    {
        IVehicleRepository Vehicles { get; }

        ICustomerRepository Customers { get; }

        Task CommitAsync();

        void Commit();

    }
}
