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

        Task<Cliente> getIdAsync(int id);

        Task addClienteAsync(Cliente obj);
    }
}
