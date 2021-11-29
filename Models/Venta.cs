using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dale.sale.api.Models
{
    public class Venta
    {
        [Key]
        public Guid Id { get; set; }
        public Guid ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public Guid ProductoId { get; set; }
        public Producto Producto { get; set; }
        public Double ValorUnitario { get; set; }  
        public int Cantidad { get; set; }  
        public Double ValorTotal { get; set; }       
     
    }
}

