using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dale.sale.api.Models
{
    public class Cliente
    {
        [Key]
        public Guid Id { get; set; }
        public long Cedula { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }       
        public String Telefono { get; set; }   
        public ICollection<Venta> ClienteVentas { get; set; }
    }
}

