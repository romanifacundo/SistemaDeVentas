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
        Task<ICollection<Cliente>> getAllAsync();

        Task<Cliente> getIdAsync(int id);

        Task CrearClienteAsync(Cliente obj);
    }
}
