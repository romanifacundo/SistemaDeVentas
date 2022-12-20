using Microsoft.EntityFrameworkCore;
using SistemaDeVentas.DomainEntities.Entities;
using SistemaDeVentas.Infraestructure.Context;
using SistemaDeVentas.Infraestructure.RepositoriesContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.Infraestructure.Repositories
{
    public class VentaRepository : IVentaRepository
    {
        private readonly DbContextSistema _context;

        public VentaRepository(DbContextSistema context)
        {
            _context = context;
        }

        public async Task<ICollection<Venta>> GetAllAsync()
        {
            return await _context.Ventas.ToListAsync();
        }

        public async Task<Venta> GetIdAsync(int id)
        {
            Venta? venta = await _context.Ventas.FirstOrDefaultAsync(v => v.Id == id);

            return venta;
        }

        public async Task AddAsync(Venta obj)
        {
            var nuevaVenta = new Venta()
            {
              
                Fecha = obj.Fecha,
                Total = obj.Total,
                
            };

            await _context.Ventas.AddAsync(nuevaVenta);
            await _context.SaveChangesAsync();
        }
    }
}
