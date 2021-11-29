using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using dale.sale.api.Models;

namespace dale.sale.api.Repositories
{
    public interface IProductoRepository
    {
        Task<Producto> Insert(Producto entity);
        Task<Producto> GetById(Guid id);
        Task<List<Producto>> GetAll();
        Task<Producto> Update(Producto entity);
        Task Delete(Guid id);

    }
}
