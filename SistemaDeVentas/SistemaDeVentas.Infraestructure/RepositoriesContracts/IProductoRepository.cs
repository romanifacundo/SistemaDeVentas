using SistemaDeVentas.DomainEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaDeVentas.Infraestructure.RepositoriesContracts
{
    public interface IProductoRepository
    {
        public ICollection<Producto> getAll();

        public Producto getProducto(int Id);
    }
}
