using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.DomainEntities.Entities
{
    /// <summary>
    /// Factura con detalle de ventas.
    /// </summary>
    public class Factura
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Cantidad { get; set; }

        [Required]
        public decimal PrecioUnitario { get; set; }

        [Required]
        public decimal Importe { get; set; }


        public int ProductoId { get; set; }

        [ForeignKey("ProductoId")]
        public Producto producto { get; set; }


        public int VentaId { get; set; }

        [ForeignKey("VentaId")]
        public Venta venta { get; set; }

    }
}
