// HNG_stage3.Controllers/MessagesController.cs

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using HNG_stage3.DTOs;
using System.Threading.Tasks;

namespace HNG_stage3.Controllers
{
    [ApiController]
    [Route("api/v1/messages")]
    public class MessagesController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ApiResponse<int>), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ApiResponse<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ApiResponse<string>), StatusCodes.Status422UnprocessableEntity)]
        public async Task<IActionResult> SendMessage([FromBody] SendMessageDto sendMessageDto)
        {
            var response = new ApiResponse<int>
            {
                Status = true,
                Message = "Message sent successfully",
                Data = 123 // Placeholder message ID
            };
            return StatusCode(StatusCodes.Status201Created, response);
        }

        [HttpGet]
        [ProducesResponseType(typeof(ApiResponse<PaginatedMessagesDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllMessages([FromQuery] int page = 1, [FromQuery] int perPage = 20)
        {
            var response = new ApiResponse<PaginatedMessagesDto>
            {
                Status = true,
                Message = "Messages retrieved successfully",
                Data = new PaginatedMessagesDto
                {
                    Messages = new List<MessageSummaryDto>(),
                    Total = 50,
                    Page = page,
                    PerPage = perPage
                }
            };
            return Ok(response);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ApiResponse<MessageDetailDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<string>), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetMessage(int id)
        {
            var response = new ApiResponse<MessageDetailDto>
            {
                Status = true,
                Message = "Message retrieved successfully",
                Data = new MessageDetailDto()
            };
            return Ok(response);
        }

        [HttpPut("{id}/read")]
        [ProducesResponseType(typeof(ApiResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<string>), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> MarkMessageAsRead(int id)
        {
            var response = new ApiResponse<string>
            {
                Status = true,
                Message = "Message marked as read",
                Data = null
            };
            return Ok(response);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(ApiResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<string>), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteMessage(int id)
        {
            var response = new ApiResponse<string>
            {
                Status = true,
                Message = "Message deleted successfully",
                Data = null
            };
            return Ok(response);
        }

        [HttpGet("unread/count")]
        [ProducesResponseType(typeof(ApiResponse<int>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetUnreadMessagesCount()
        {
            var response = new ApiResponse<int>
            {
                Status = true,
                Message = "Unread messages count retrieved successfully",
                Data = 5 // Placeholder count
            };
            return Ok(response);
        }

        [HttpGet("sent")]
        [ProducesResponseType(typeof(ApiResponse<PaginatedMessagesDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetSentMessages([FromQuery] int page = 1, [FromQuery] int perPage = 20)
        {
            var response = new ApiResponse<PaginatedMessagesDto>
            {
                Status = true,
                Message = "Sent messages retrieved successfully",
                Data = new PaginatedMessagesDto
                {
                    Messages = new List<MessageSummaryDto>(),
                    Total = 30,
                    Page = page,
                    PerPage = perPage
                }
            };
            return Ok(response);
        }

        [HttpGet("received")]
        [ProducesResponseType(typeof(ApiResponse<PaginatedMessagesDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetReceivedMessages([FromQuery] int page = 1, [FromQuery] int perPage = 20)
        {
            var response = new ApiResponse<PaginatedMessagesDto>
            {
                Status = true,
                Message = "Received messages retrieved successfully",
                Data = new PaginatedMessagesDto
                {
                    Messages = new List<MessageSummaryDto>(),
                    Total = 40,
                    Page = page,
                    PerPage = perPage
                }
            };
            return Ok(response);
        }

        [HttpGet("search")]
        [ProducesResponseType(typeof(ApiResponse<PaginatedMessagesDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<string>), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> SearchMessages([FromQuery] string q, [FromQuery] int page = 1, [FromQuery] int perPage = 20)
        {
            if (string.IsNullOrWhiteSpace(q))
            {
                return BadRequest(new ApiResponse<string> { Status = false, Message = "Search query is required", Data = null });
            }

            var response = new ApiResponse<PaginatedMessagesDto>
            {
                Status = true,
                Message = "Messages searched successfully",
                Data = new PaginatedMessagesDto
                {
                    Messages = new List<MessageSummaryDto>(),
                    Total = 10,
                    Page = page,
                    PerPage = perPage
                }
            };
            return Ok(response);
        }

        [HttpGet("templates")]
        [ProducesResponseType(typeof(ApiResponse<PaginatedMessagesDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetMessageTemplates([FromQuery] int page = 1, [FromQuery] int perPage = 20)
        {
            var response = new ApiResponse<PaginatedMessagesDto>
            {
                Status = true,
                Message = "Message templates retrieved successfully",
                Data = new PaginatedMessagesDto
                {
                    Messages = new List<MessageSummaryDto>(),
                    Total = 40,
                    Page = page,
                    PerPage = perPage
                }
            };
            return Ok(response);
        }

        [HttpGet("templates/{id}")]
        [ProducesResponseType(typeof(ApiResponse<MessageTemplateDetailDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<string>), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetMessageTemplate(int id)
        {
            var response = new ApiResponse<MessageTemplateDetailDto>
            {
                Status = true,
                Message = "Message template retrieved successfully",
                Data = new MessageTemplateDetailDto()
            };
            return Ok(response);
        }

        [HttpPost("send-template")]
        [ProducesResponseType(typeof(ApiResponse<int>), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ApiResponse<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ApiResponse<string>), StatusCodes.Status422UnprocessableEntity)]
        [ProducesResponseType(typeof(ApiResponse<string>), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> SendTemplateMessage([FromBody] SendTemplateMessageDto sendTemplateMessageDto)
        {
            var response = new ApiResponse<int>
            {
                Status = true,
                Message = "Template message sent successfully",
                Data = 124 // Placeholder message ID
            };
            return StatusCode(StatusCodes.Status201Created, response);
        }
    }
}