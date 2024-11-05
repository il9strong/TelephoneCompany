using Microsoft.AspNetCore.Mvc;
using TelephoneCompany.Entities;
using TelephoneCompany.Interfaces.Services;

namespace TelephoneCompany.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RequestController : ControllerBase
    {
        private readonly IRequestService _requestService;

        public RequestController(IRequestService requestService)
        {
            _requestService = requestService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRequestById(int id)
        {
            var request = await _requestService.GetRequestById(id);
            if (request == null)
            {
                return NotFound();
            }
            return Ok(request);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRequests()
        {
            var requests = await _requestService.GetAllRequests();
            return Ok(requests);
        }

        [HttpPost]
        public async Task<IActionResult> AddRequest([FromBody] Request request)
        {
            await _requestService.AddRequest(request);
            return CreatedAtAction(nameof(GetRequestById), new { id = request.RequestId }, request);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRequest(int id, [FromBody] Request request)
        {
            if (id != request.RequestId)
            {
                return BadRequest();
            }
            await _requestService.UpdateRequest(request);
            return Ok(request);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRequest(int id)
        {
            await _requestService.DeleteRequest(id);
            return NoContent();
        }
    }
}
