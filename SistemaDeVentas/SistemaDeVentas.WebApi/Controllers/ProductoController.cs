using Microsoft.AspNetCore.Mvc;
using SistemaDeVentas.Application.Services;
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
        public async Task<IActionResult> Get()
        {
            ICollection<Producto> listaProductos = await _productsRepository.getAllAsync();

            return Ok(listaProductos); 
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get(int Id) 
        {
            var producto = await _productoService.GetIdAasync(Id);

            return Ok(producto);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Producto obj)
        {
            try
            {
                await _productoService.AddProductoAsync(obj);
                return Ok();
            }
            catch (Exception ex)
            {
                return Ok(BadRequest());
            }          
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id , Producto obj)
        {
            var producto = await _productoService.GetIdAasync(id);

            if(producto.Id != obj.Id)
            {
                return BadRequest("Is Null");
            }
            else
            {
                await _productoService.UpdateAsync(obj);
                return Ok();
            }

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) 
        {
            try
            {
                await _productoService.DeleteAsync(id);
                return Ok("Producto deleted with success");
            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }
    }
}


