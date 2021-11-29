using dale.sale.api.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using dale.sale.api.Models;
using AutoMapper;
using dale.sale.api.Dtos;
using System;

namespace dale.sale.api.Services
{
    public class VentaService : IVentaService
    {
        private IVentaRepository _repository;
        private readonly IMapper _mapper;

        public VentaService(IVentaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Delete(Guid id)
        {
             await _repository.Delete(id);
        }

        public async Task<List<VentaDto>> GetAll()
        {
            var list = await _repository.GetAll();

            return _mapper.Map<List<Venta>, List<VentaDto>>(list);
        }

        public async Task<VentaDto> GetById(Guid id)
        {

            var entity  = await _repository.GetById(id);
            return _mapper.Map<Venta, VentaDto>(entity);

        }

        public async Task<VentaDto> Insert(VentaDto dto)
        {
            var entity  = _mapper.Map<VentaDto, Venta>(dto);
            entity = await _repository.Insert(entity);
            return _mapper.Map<Venta, VentaDto>(entity);
        }

        public async Task<VentaDto> Update(VentaDto dto)
        {
            var entity  = _mapper.Map<VentaDto, Venta>(dto);
            entity = await _repository.Update(entity);
            return _mapper.Map<Venta, VentaDto>(entity);
        }
    }
}