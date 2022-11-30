using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.DomainEntities.Entities
{
    /// <summary>
    /// Detalle de venta.
    /// </summary>
    public class Venta
    {
        [Key]
        public int Id { get; set; }
        public DateTime? Fecha { get; set; }
        public int Id_cliente { get; set; }
        public decimal Total { get; set; }
        public ICollection<Producto> Productos { get; set; }
    }
}
