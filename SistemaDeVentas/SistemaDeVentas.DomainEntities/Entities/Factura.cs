using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public int Id_venta { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Importe { get; set; }
        public int Id_producto { get; set; }

    }
}
