using Microsoft.AspNetCore.Mvc;
using SistemaDeVentas.Application.ServicesContracts;
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
        private readonly IProductoService _productoService;

        public ProductoController(IProductoRepository productsRepository, IProductoService productoService)
        {
            _productsRepository = productsRepository;
            _productoService = productoService;
        }


        [HttpGet]
        public IActionResult Get()
        {
            ICollection<Producto> Lista = _productsRepository.getAll();
            return Ok(Lista);
        }

        [HttpGet("{Id}")]
        public IActionResult Get(int Id) 
        {
            var producto = _productoService.getId(Id);
            return Ok(producto);
        }
    }
}


