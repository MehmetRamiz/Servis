using ServisProgrami.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServisProgrami.Core.Repositories
{
   public interface ICustomerRepository:IRepository<Customer>
    {
        Task<Customer> GetWithCustomersByIdAsync(int customerId);
    }
}
