using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using dale.sale.api.Dtos;

namespace dale.sale.api.Services
{
    public interface IProductoService
    {
        Task<ProductoDto> Insert(ProductoDto dto);
        Task<ProductoDto> GetById(Guid id);
        Task<List<ProductoDto>> GetAll();
        Task<ProductoDto> Update(ProductoDto entity);
        Task Delete(Guid id);

    }
}
