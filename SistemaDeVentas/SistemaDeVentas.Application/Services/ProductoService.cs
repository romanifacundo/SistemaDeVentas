using SistemaDeVentas.Application.ServicesContracts;
using SistemaDeVentas.DomainEntities.Entities;
using SistemaDeVentas.Infraestructure.Repositories;
using SistemaDeVentas.Infraestructure.RepositoriesContracts;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Runtime.CompilerServices;
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
            var producto = await _productoRepository.GetProductoAsync(Id);

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
            return  _productoRepository.AddProductoAsync(obj);
        }

        public Task UpdateAsync(Producto obj)
        {
            return _productoRepository.UpdateAsync(obj);
        }

        public async Task DeleteAsync(int id)
        {
            if(id != null) 
            {
                await _productoRepository.DeleteAsync(id); 
            }
            else
            {
                throw new Exception("Entity is null");
            }
        }
    }
}
