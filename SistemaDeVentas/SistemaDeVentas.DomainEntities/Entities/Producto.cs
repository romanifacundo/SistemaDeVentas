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
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Costo { get; set; }
        public decimal PrecioUnitario { get; set; }
        public ICollection<Venta> Ventas { get; set; }

    }
}
