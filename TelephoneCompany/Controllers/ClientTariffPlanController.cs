using Microsoft.AspNetCore.Mvc;
using TelephoneCompany.Entities;
using TelephoneCompany.Interfaces.Services;

namespace TelephoneCompany.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientTariffPlanController : ControllerBase
    {
        private readonly IClientTariffPlanService _clientTariffPlanService;

        public ClientTariffPlanController(IClientTariffPlanService clientTariffPlanService)
        {
            _clientTariffPlanService = clientTariffPlanService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetClientTariffPlanById(int id)
        {
            var clientTariffPlan = await _clientTariffPlanService.GetClientTariffPlanById(id);
            if (clientTariffPlan == null)
            {
                return NotFound();
            }
            return Ok(clientTariffPlan);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllClientTariffPlans()
        {
            var clientTariffPlans = await _clientTariffPlanService.GetAllClientTariffPlans();
            return Ok(clientTariffPlans);
        }

        [HttpPost]
        public async Task<IActionResult> AddClientTariffPlan([FromBody] ClientTariffPlan clientTariffPlan)
        {
            await _clientTariffPlanService.AddClientTariffPlan(clientTariffPlan);
            return CreatedAtAction(nameof(GetClientTariffPlanById), new { id = clientTariffPlan.Id }, clientTariffPlan);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateClientTariffPlan(int id, [FromBody] ClientTariffPlan clientTariffPlan)
        {
            if (id != clientTariffPlan.Id)
            {
                return BadRequest();
            }
            await _clientTariffPlanService.UpdateClientTariffPlan(clientTariffPlan);
            return Ok(clientTariffPlan);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClientTariffPlan(int id)
        {
            await _clientTariffPlanService.DeleteClientTariffPlan(id);
            return NoContent();
        }
    }
}
