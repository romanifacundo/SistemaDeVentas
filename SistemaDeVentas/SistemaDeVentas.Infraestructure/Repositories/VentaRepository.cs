using Microsoft.EntityFrameworkCore;
using SistemaDeVentas.DomainEntities.Entities;
using SistemaDeVentas.DomainEntities.EntityDTO;
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
            return _context.Ventas.Include(v => v.Cliente).ToList();  
        }

        public async Task<Venta> GetIdAsync(int id)
        {
            Venta? venta = await _context.Ventas.FirstOrDefaultAsync(v => v.Id == id);

            return venta;
        }

        public async Task AddAsync(VentaDTO ventaDTO)
        {
            var nuevaVenta = new Venta()
            {

                Fecha = ventaDTO.Fecha,
                Total = ventaDTO.Total,
                ClienteId = ventaDTO.ClienteId,

            };

            await _context.Ventas.AddAsync(nuevaVenta);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsycn(int id)
        {
            var venta =  _context.Ventas.Where(v => v.Id == id).Select(v => v).FirstOrDefault();

            _context.Ventas.Remove(venta);
            _context.SaveChanges();
        }
    }
}
