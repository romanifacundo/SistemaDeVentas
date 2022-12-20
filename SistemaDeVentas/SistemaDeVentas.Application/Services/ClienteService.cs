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
        public Task<ICollection<Cliente>> GetAllAsync()
        {
            return _clienteRepository.GetAllAsync();
        }

        public Task<Cliente> GetIdAsync(int id)
        {
            var cliente = _clienteRepository.GetIdAsync(id);

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

            return  _clienteRepository.AddClienteAsync(obj);
        }

        public Task Update(Cliente obj)
        {

            return _clienteRepository.UpdateClienteAsync(obj);

        }

        public async Task Delete(int id)
        {
            if (id != null)
            {
                await _clienteRepository.DeleteAsync(id);
            }
            else
            {
                throw new Exception("Is null");
            }
        }
    }
}
