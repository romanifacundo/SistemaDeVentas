using SistemaDeVentas.Application.ServicesContracts;
using SistemaDeVentas.DomainEntities.Entities;
using SistemaDeVentas.DomainEntities.EntityDTO;
using SistemaDeVentas.Infraestructure.Repositories;
using SistemaDeVentas.Infraestructure.RepositoriesContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.Application.Services
{
    public class VentaService : IVentaService
    {
        private readonly IVentaRepository _ventaRepository;
        public VentaService(IVentaRepository ventaRepository)
        {
            _ventaRepository = ventaRepository;
        }

        public Task<ICollection<Venta>> GetAllAsync()
        {
            return _ventaRepository.GetAllAsync();
        }

        public async Task<Venta> GetIdAsync(int id)
        {
            if (id != null)
            {
                var venta = await _ventaRepository.GetIdAsync(id);
                return venta;
            }
            else
            {
                throw new Exception("Is Null");
            }
        }

        public Task AddAsync(VentaDTO ventaDTO)
        {
            return _ventaRepository.AddAsync(ventaDTO);
        }
    }
}
