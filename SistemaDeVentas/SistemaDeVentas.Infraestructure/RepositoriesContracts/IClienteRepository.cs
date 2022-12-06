using SistemaDeVentas.DomainEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.Infraestructure.RepositoriesContracts
{
    public interface IClienteRepository
    {
        Task<ICollection<Cliente>> GetAllAsync();

        Task<Cliente> GetIdAsync(int id);

        Task AddClienteAsync(Cliente obj);

        Task UpdateClienteAsync(Cliente obj);

        Task DeleteAsync(int id);
    }
}
