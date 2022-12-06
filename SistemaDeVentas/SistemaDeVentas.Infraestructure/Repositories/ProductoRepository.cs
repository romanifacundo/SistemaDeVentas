using Microsoft.EntityFrameworkCore;
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
            _context = context;
        }

        public async Task<ICollection<Producto>> getAllAsync()
        {
            return await _context.Productos.ToListAsync();
        }

        public async Task<Producto> getProductoAsync(int Id)
        {
            Producto? producto = await _context.Productos.FirstOrDefaultAsync(x => x.Id == Id);

            return producto;
        }

        public async Task AddProductoAsync(Producto obj)
        {
            var nuevoProducto = new Producto()
            {
                Id = obj.Id,
                Nombre = obj.Nombre,
                Costo = obj.Costo,
                PrecioUnitario = obj.PrecioUnitario,
            };

            await _context.Productos.AddAsync(nuevoProducto);
            await _context.SaveChangesAsync();
        
        }

        public async Task UpdateAsync(Producto obj)
        {
            Producto? producto = await _context.Productos.FirstOrDefaultAsync(x => x.Id == obj.Id);

            if (producto != null)
            {   
                producto.Nombre = obj.Nombre;
                producto.Costo = obj.Costo;
                producto.PrecioUnitario = obj.PrecioUnitario;

                await _context.SaveChangesAsync();
            }
        
        }
            
        public async Task DeleteAsync(int id)
        {
            Producto? producto = await _context.Productos.FirstOrDefaultAsync(x=> x.Id == id);
            _context.Productos.Remove(producto);
            await _context.SaveChangesAsync();    
        }
    }
}
