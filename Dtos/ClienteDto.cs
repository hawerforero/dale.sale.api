using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dale.sale.api.Dtos
{
    public class ClienteDto
    {
        public Guid Id { get; set; }
        public long Cedula { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }       
        public String Telefono { get; set; }   
    }
}

