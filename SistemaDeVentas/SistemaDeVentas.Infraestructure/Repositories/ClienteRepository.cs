using Microsoft.EntityFrameworkCore;
using SistemaDeVentas.DomainEntities.Entities;
using SistemaDeVentas.Infraestructure.Context;
using SistemaDeVentas.Infraestructure.RepositoriesContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.Infraestructure.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly DbContextSistema _context;
        public ClienteRepository(DbContextSistema contex)
        {
            _context = contex;
        }
        public async Task<ICollection<Cliente>> GetAllAsync()
        {
            return await _context.Clientes.ToListAsync();
        }

        public async Task<Cliente> getIdAsync(int id)
        {
            return await _context.Clientes.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task addClienteAsync(Cliente obj) 
        {
            var nuevoCliente = new Cliente()
            {
                Id = obj.Id,
                Nombre = obj.Nombre,
                Apellido = obj.Apellido,
                Email = obj.Email,
            };

            await _context.Clientes.AddAsync(nuevoCliente);
            await _context.SaveChangesAsync();
        }
            
        public async Task updateClienteAsync(Cliente obj)
        {
            var cliente = await _context.Clientes.FirstOrDefaultAsync(c =>c.Id == obj.Id);

            if (cliente != null)
            {
                cliente.Nombre = obj.Nombre;
                cliente.Apellido = obj.Apellido;
                cliente.Email = obj.Email;
                
                await _context.SaveChangesAsync();
            }

      
        }
    }
}
