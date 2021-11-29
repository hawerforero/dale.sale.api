using dale.sale.api.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using dale.sale.api.Models;
using AutoMapper;
using dale.sale.api.Dtos;
using System;

namespace dale.sale.api.Services
{
    public class ProductoService : IProductoService
    {
        private IProductoRepository _repository;
        private readonly IMapper _mapper;

        public ProductoService(IProductoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Delete(Guid id)
        {
             await _repository.Delete(id);
        }

        public async Task<List<ProductoDto>> GetAll()
        {
            var list = await _repository.GetAll();

            return _mapper.Map<List<Producto>, List<ProductoDto>>(list);
        }

        public async Task<ProductoDto> GetById(Guid id)
        {

            var entity  = await _repository.GetById(id);
            return _mapper.Map<Producto, ProductoDto>(entity);

        }

        public async Task<ProductoDto> Insert(ProductoDto dto)
        {
            var entity  = _mapper.Map<ProductoDto, Producto>(dto);
            entity = await _repository.Insert(entity);
            return _mapper.Map<Producto, ProductoDto>(entity);
        }

        public async Task<ProductoDto> Update(ProductoDto dto)
        {
            var entity  = _mapper.Map<ProductoDto, Producto>(dto);
            entity = await _repository.Update(entity);
            return _mapper.Map<Producto, ProductoDto>(entity);
        }
    }
}