using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dale.sale.api.Models
{
    public class Producto
    {
        [Key]
        public Guid Id { get; set; }
        public String Nombre { get; set; }
        public Double Valor { get; set; } 
        public ICollection<Venta> ProductoVentas { get; set; }
      
    }
}

