using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaDeVentas.Application.ServicesContracts;
using SistemaDeVentas.DomainEntities.Entities;
using SistemaDeVentas.DomainEntities.EntityDTO;
using SistemaDeVentas.Infraestructure.Context;

namespace SistemaDeVentas.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        private readonly IVentaService _ventaService;

        public VentaController(IVentaService ventaService, DbContextSistema context)
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
        public async Task<ActionResult> CrearVenta(VentaDTO ventaDTO)
        {
            if (ventaDTO == null)
            {
                _ventaService.AddAsync(ventaDTO);
                return Ok(ventaDTO);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
