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

        [Required]
        public string? Nombre { get; set; }

        [Required]
        public decimal Costo { get; set; }

        [Required]
        public decimal PrecioUnitario { get; set; }


    }
}
