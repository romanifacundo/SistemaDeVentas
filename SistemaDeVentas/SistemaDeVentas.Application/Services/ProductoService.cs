using SistemaDeVentas.Application.ServicesContracts;
using SistemaDeVentas.DomainEntities.Entities;
using SistemaDeVentas.Infraestructure.Repositories;
using SistemaDeVentas.Infraestructure.RepositoriesContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.Application.Services
{
    public class ProductoService : IProductoService
    {
        private readonly IProductoRepository _productoRepository;

        public ProductoService(IProductoRepository productoRepository) 
        {
            _productoRepository = productoRepository;
        }
        public Producto getId(int Id)
        {
            Producto producto = _productoRepository.getProducto(Id);

            if(producto is null) 
            {
                throw new Exception("Entity is null");
            }
            else
            {
                return producto;
            }
        }
    }
}
