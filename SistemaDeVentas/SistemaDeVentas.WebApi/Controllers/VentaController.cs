using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaDeVentas.Application.ServicesContracts;
using SistemaDeVentas.DomainEntities.Entities;

namespace SistemaDeVentas.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        private readonly IVentaService _ventaService;

        public VentaController(IVentaService ventaService)
        {
            _ventaService = ventaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetVentas() 
        {
            var ventas = await _ventaService.GetAllAsync();
            return Ok(ventas);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetVentaId(int id)
        {
            var venta = _ventaService.GetIdAsync(id);
            return Ok(venta);
        }

        [HttpPost]
        public async Task<IActionResult> CrearVenta(Venta obj) 
        {
            if(obj.Id != 0)
            {
                var nuevaVenta = _ventaService.AddAsync(obj);
                return Ok(nuevaVenta);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
