using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using HNG_stage3.DTOs;

namespace HNG_stage3.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/v1/widgets")]
    public class WidgetsController : ControllerBase
    {
        [HttpPost("")]
        [ProducesResponseType(typeof(UserWidgetDto), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(object), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(object), StatusCodes.Status404NotFound)]
        public IActionResult AddUserWidget([FromBody] AddUserWidgetDto addUserWidgetDto)
        {
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(UserWidgetDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(object), StatusCodes.Status404NotFound)]
        public IActionResult GetUserWidget([FromRoute] int id)
        {
            return Ok();
        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(UserWidgetDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(object), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(object), StatusCodes.Status404NotFound)]
        public IActionResult UpdateUserWidget([FromRoute] int id, [FromBody] UpdateUserWidgetDto updateUserWidgetDto)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(object), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(object), StatusCodes.Status404NotFound)]
        public IActionResult DeleteUserWidget([FromRoute] int id)
        {
            return NoContent();
        }

        [HttpGet("user-widgets")]
        [ProducesResponseType(typeof(UserWidgetListDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(object), StatusCodes.Status401Unauthorized)]
        public IActionResult ListUserWidgets([FromQuery] int page = 1, [FromQuery] int per_page = 20)
        {
            return Ok();
        }

        [HttpGet("widgets")]
        [ProducesResponseType(typeof(WidgetTypeListDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(object), StatusCodes.Status401Unauthorized)]
        public IActionResult ListAvailableWidgetTypes([FromQuery] int page = 1, [FromQuery] int per_page = 20)
        {
            return Ok();
        }
    }
}