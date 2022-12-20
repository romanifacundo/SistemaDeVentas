using SistemaDeVentas.DomainEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.Application.ServicesContracts
{
    public interface IVentaService
    {
        Task<ICollection<Venta>> GetAllAsync();
    }
}
