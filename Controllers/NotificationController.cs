using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using HNG_stage3.DTOs;

namespace HNG_stage3.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/v1/notifications")]
    public class NotificationsController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(NotificationDto), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(object), StatusCodes.Status401Unauthorized)]
        public IActionResult CreateNotification([FromBody] CreateNotificationDto createNotificationDto)
        {
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(NotificationDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(object), StatusCodes.Status404NotFound)]
        public IActionResult GetNotification([FromRoute] int id)
        {
            return Ok();
        }

        [HttpPut("{id}/read")]
        [ProducesResponseType(typeof(NotificationDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(object), StatusCodes.Status404NotFound)]
        public IActionResult MarkNotificationAsRead([FromRoute] int id)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(object), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(object), StatusCodes.Status404NotFound)]
        public IActionResult DeleteNotification([FromRoute] int id)
        {
            return NoContent();
        }

        [HttpGet]
        [ProducesResponseType(typeof(NotificationListDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(object), StatusCodes.Status401Unauthorized)]
        public IActionResult ListUserNotifications(
            [FromQuery] int page = 1, 
            [FromQuery] int per_page = 20, 
            [FromQuery] bool? is_read = null)
        {
            return Ok();
        }

        [HttpPut("read-all")]
        [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status401Unauthorized)]
        public IActionResult MarkAllNotificationsAsRead()
        {
            return Ok(new { message = "All notifications marked as read" });
        }
    }
}