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
        public async Task<Producto> getIdAasync(int Id)
        {
            var producto = await _productoRepository.getProductoAsync(Id);

            if(producto is null) 
            {
                throw new Exception("Entity is null");
            }
            else
            {
                return producto;
            }
        }

        public Task AddProductoAsync(Producto obj)
        {      
            return _productoRepository.AddProductoAsync(obj);
        }
    }
}
