using Microsoft.AspNetCore.Mvc;
using TelephoneCompany.Entities;
using TelephoneCompany.Interfaces.Services;

namespace TelephoneCompany.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientServiceController : ControllerBase
    {
        private readonly IClientServiceService _clientServiceService;

        public ClientServiceController(IClientServiceService clientServiceService)
        {
            _clientServiceService = clientServiceService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetClientServiceById(int id)
        {
            var clientService = await _clientServiceService.GetClientServiceById(id);
            if (clientService == null)
            {
                return NotFound();
            }
            return Ok(clientService);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllClientServices()
        {
            var clientServices = await _clientServiceService.GetAllClientServices();
            return Ok(clientServices);
        }

        [HttpPost]
        public async Task<IActionResult> AddClientService([FromBody] ClientService clientService)
        {
            await _clientServiceService.AddClientService(clientService);
            return CreatedAtAction(nameof(GetClientServiceById), new { id = clientService.Id }, clientService);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateClientService(int id, [FromBody] ClientService clientService)
        {
            if (id != clientService.Id)
            {
                return BadRequest();
            }
            await _clientServiceService.UpdateClientService(clientService);
            return Ok(clientService);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClientService(int id)
        {
            await _clientServiceService.DeleteClientService(id);
            return NoContent();
        }
    }
}
