using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaDeVentas.Application.ServicesContracts;
using SistemaDeVentas.DomainEntities.Entities;

namespace SistemaDeVentas.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : Controller
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }


        [HttpGet]
        public async Task<IActionResult> getClientes()
        {
            ICollection<Cliente> listaClientes = await _clienteService.GetAllAsync();

            return Ok(listaClientes);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> getId(int id)
        {
            var cliente = await _clienteService.GetIdAsync(id);
            
            if(cliente.Id != id)
            {
                return NotFound();
            }
            else
            {
                return Ok(cliente);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CrearCliente([FromBody] Cliente obj) 
        {
            try
            {
                await _clienteService.CrearClienteAsync(obj);
                return Ok();
            }
            catch (Exception ex)
            {

                return Ok(BadRequest());
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualiazarCliente(int id , Cliente obj)
        {
            if(obj.Id != id)
            {
                return Ok(BadRequest("Is Null"));
            }
            else
            {
                await _clienteService.Update(obj);
                return Ok();
            }
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteCliente(int id)
        {
            try
            {
                await _clienteService.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
