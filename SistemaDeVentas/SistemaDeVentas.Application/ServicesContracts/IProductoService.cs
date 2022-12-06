using SistemaDeVentas.DomainEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.Application.ServicesContracts
{
    public interface IProductoService
    {
        Task<Producto> GetIdAasync(int Id);

        Task AddProductoAsync(Producto obj);

        Task UpdateAsync(Producto obj);

        Task DeleteAsync(int Id);

    }
}
