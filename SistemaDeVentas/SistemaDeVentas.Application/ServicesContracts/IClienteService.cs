using SistemaDeVentas.DomainEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.Application.ServicesContracts
{
    public interface IClienteService
    {
        Task<ICollection<Cliente>> GetAllAsync();

        Task<Cliente> GetIdAsync(int id);

        Task CrearClienteAsync(Cliente obj);

        Task Update(Cliente obj);

        Task Delete(int id);
    }
}
