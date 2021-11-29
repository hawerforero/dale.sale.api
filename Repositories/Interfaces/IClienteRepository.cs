using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using dale.sale.api.Models;

namespace dale.sale.api.Repositories
{
    public interface IClienteRepository
    {
        Task<Cliente> Insert(Cliente entity);
        Task<Cliente> GetById(Guid id);
         Task<List<Cliente>> GetAll();
        Task<Cliente> Update(Cliente entity);
        Task Delete(Guid id);
    }
}
