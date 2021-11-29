using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using dale.sale.api.Dtos;

namespace dale.sale.api.Services
{
    public interface IClienteService
    {
        Task<ClienteDto> Insert(ClienteDto dto);
        Task<ClienteDto> GetById(Guid id);
        Task<List<ClienteDto>> GetAll();
        Task<ClienteDto> Update(ClienteDto entity);
        Task Delete(Guid id);

    }
}
