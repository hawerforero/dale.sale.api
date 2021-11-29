using AutoMapper;
using dale.sale.api.Dtos;
using dale.sale.api.Models;

namespace dale.sale.api.Dtos.Mappings
{
    public class ApplicationMapping : Profile
    {
        public ApplicationMapping()
        {
            CreateMap<ProductoDto, Producto>().ReverseMap();
            CreateMap<ClienteDto, Cliente>().ReverseMap();
            CreateMap<VentaDto, Venta>().ReverseMap();
        }
    }
}
