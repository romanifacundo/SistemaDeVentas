using SistemaDeVentas.DomainEntities.Entities;
using SistemaDeVentas.Infraestructure.Context;
using SistemaDeVentas.Infraestructure.RepositoriesContracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.Infraestructure.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        readonly private DbContextSistema _context;

        public ProductoRepository(DbContextSistema context) 
        { 
            _context= context;
        }

        public ICollection<Producto> getAll()
        {
            //ICollection<Producto> listaProductos = 
            return _context.Productos.ToList(); 
        }
    }
}
