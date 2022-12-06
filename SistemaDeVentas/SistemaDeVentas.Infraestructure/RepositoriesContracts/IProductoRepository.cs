using SistemaDeVentas.DomainEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaDeVentas.Infraestructure.RepositoriesContracts
{
    public interface IProductoRepository
    {
        Task<ICollection<Producto>> GetAllAsync();

        Task<Producto> GetProductoAsync(int Id);

        Task AddProductoAsync(Producto obj);

        Task UpdateAsync(Producto obj);

        Task DeleteAsync(int Id);
    }
}
