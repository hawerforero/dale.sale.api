using dale.sale.api.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using dale.sale.api.Models;
using AutoMapper;
using dale.sale.api.Dtos;
using System;

namespace dale.sale.api.Services
{
    public class ClienteService : IClienteService
    {
        private IClienteRepository _repository;
        private readonly IMapper _mapper;

        public ClienteService(IClienteRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Delete(Guid id)
        {
             await _repository.Delete(id);
        }

        public async Task<List<ClienteDto>> GetAll()
        {
            var list = await _repository.GetAll();

            return _mapper.Map<List<Cliente>, List<ClienteDto>>(list);
        }

        public async Task<ClienteDto> GetById(Guid id)
        {

            var entity  = await _repository.GetById(id);
            return _mapper.Map<Cliente, ClienteDto>(entity);

        }

        public async Task<ClienteDto> Insert(ClienteDto dto)
        {
            var entity  = _mapper.Map<ClienteDto, Cliente>(dto);
            entity = await _repository.Insert(entity);
            return _mapper.Map<Cliente, ClienteDto>(entity);
        }

        public async Task<ClienteDto> Update(ClienteDto dto)
        {
            var entity  = _mapper.Map<ClienteDto, Cliente>(dto);
            entity = await _repository.Update(entity);
            return _mapper.Map<Cliente, ClienteDto>(entity);
        }
    }
}