using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.DomainEntities.EntityDTO
{
    public class VentaDTO
    {
       
        public DateTime Fecha { get; set; }

        public decimal Total { get; set; }

        public int ClienteId { get; set; }
    }
}
