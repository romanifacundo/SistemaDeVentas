using Microsoft.AspNetCore.Mvc;
using SistemaDeVentas.DomainEntities.Entities;
using SistemaDeVentas.Infraestructure.Repositories;
using SistemaDeVentas.Infraestructure.RepositoriesContracts;

namespace SistemaDeVentas.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductoController : Controller
    { 
        private readonly IProductoRepository _productsRepository;

        public ProductoController(IProductoRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }

    
        [HttpGet]
        public IActionResult Get()
        {
            ICollection<Producto> Lista = _productsRepository.getAll();
            return Ok(Lista);
        }

    }
}


