using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using dale.sale.api.Models;

namespace dale.sale.api.Repositories
{
    public interface IVentaRepository
    {
        Task<Venta> Insert(Venta entity);
        Task<Venta> GetById(Guid id);
         Task<List<Venta>> GetAll();
        Task<Venta> Update(Venta entity);
        Task Delete(Guid id);
    }
}
