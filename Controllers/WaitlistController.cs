using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using HNG_stage3.DTOs;
namespace HNG_stage3.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/v1/waitlist")]
    public class WaitlistController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(WaitlistEntryDto), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(object), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(object), StatusCodes.Status409Conflict)]
        public IActionResult CreateWaitlistEntry([FromBody] CreateWaitlistEntryDto createWaitlistEntryDto)
        {
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(WaitlistEntryDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(object), StatusCodes.Status404NotFound)]
        public IActionResult GetWaitlistEntry([FromRoute] int id)
        {
            return Ok();
        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(WaitlistEntryDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(object), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(object), StatusCodes.Status404NotFound)]
        public IActionResult UpdateWaitlistEntry([FromRoute] int id, [FromBody] UpdateWaitlistEntryDto updateWaitlistEntryDto)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(object), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(object), StatusCodes.Status404NotFound)]
        public IActionResult DeleteWaitlistEntry([FromRoute] int id)
        {
            return NoContent();
        }

        [HttpGet]
        [ProducesResponseType(typeof(WaitlistEntriesListDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(object), StatusCodes.Status401Unauthorized)]
        public IActionResult ListWaitlistEntries(
            [FromQuery] int page = 1,
            [FromQuery] int per_page = 20,
            [FromQuery] string? status = null)
        {
            return Ok();
        }
    }
}