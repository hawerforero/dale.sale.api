using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dale.sale.api.Dtos
{
    public class VentaDto
    {
        public Guid Id { get; set; }
        public Guid ClienteId { get; set; }
        public ClienteDto Cliente { get; set; }
        public Guid ProductoId { get; set; }
        public ProductoDto Producto { get; set; }
        public Double ValorUnitario { get; set; }  
        public int Cantidad { get; set; }  
        public Double ValorTotal { get; set; }       
     
    }
}

