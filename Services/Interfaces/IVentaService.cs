using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using dale.sale.api.Dtos;
using dale.sale.api.Models;

namespace dale.sale.api.Services
{
    public interface IVentaService
    {
        Task<VentaDto> Insert(VentaDto dto);
        Task<VentaDto> GetById(Guid id);
        Task<List<VentaDto>> GetAll();
        Task<VentaDto> Update(VentaDto entity);
        Task Delete(Guid id);

    }
}
