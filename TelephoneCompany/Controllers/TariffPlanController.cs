using Microsoft.AspNetCore.Mvc;
using TelephoneCompany.Entities;
using TelephoneCompany.Interfaces.Services;

namespace TelephoneCompany.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TariffPlanController : ControllerBase
    {
        private readonly ITariffPlanService _tariffPlanTariffPlan;

        public TariffPlanController(ITariffPlanService tariffPlanTariffPlan)
        {
            _tariffPlanTariffPlan = tariffPlanTariffPlan;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTariffPlanById(int id)
        {
            var tariffPlan = await _tariffPlanTariffPlan.GetTariffPlanById(id);
            if (tariffPlan == null)
            {
                return NotFound();
            }
            return Ok(tariffPlan);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTariffPlans()
        {
            var tariffPlans = await _tariffPlanTariffPlan.GetAllTariffPlans();
            return Ok(tariffPlans);
        }

        [HttpPost]
        public async Task<IActionResult> AddTariffPlan([FromBody] TariffPlan tariffPlan)
        {
            await _tariffPlanTariffPlan.AddTariffPlan(tariffPlan);
            return CreatedAtAction(nameof(GetTariffPlanById), new { id = tariffPlan.PlanId }, tariffPlan);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTariffPlan(int id, [FromBody] TariffPlan tariffPlan)
        {
            if (id != tariffPlan.PlanId)
            {
                return BadRequest();
            }
            await _tariffPlanTariffPlan.UpdateTariffPlan(tariffPlan);
            return Ok(tariffPlan);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTariffPlan(int id)
        {
            await _tariffPlanTariffPlan.DeleteTariffPlan(id);
            return NoContent();
        }
    }
}
