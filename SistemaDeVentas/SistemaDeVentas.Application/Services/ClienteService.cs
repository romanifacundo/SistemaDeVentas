using SistemaDeVentas.Application.ServicesContracts;
using SistemaDeVentas.DomainEntities.Entities;
using SistemaDeVentas.Infraestructure.RepositoriesContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.Application.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public Task<ICollection<Cliente>> getAllAsync()
        {
            return _clienteRepository.GetAllAsync();
        }

        public Task<Cliente> getIdAsync(int id)
        {
            var cliente = _clienteRepository.getIdAsync(id);

            if (cliente == null)
            {
                throw new Exception("Entity is null");
            }
            else
            {
                return cliente;
            }
        }

        public Task CrearClienteAsync(Cliente obj)
        {
            //if(obj != null)
            //{

            //}
            //else
            //{
            //    throw new Exception("Cliente Existe");
            //}

            return _clienteRepository.addClienteAsync(obj);
        }

        public Task Update(Cliente obj)
        {

            return _clienteRepository.updateClienteAsync(obj);

        }
    }
}
