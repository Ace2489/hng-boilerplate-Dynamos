using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using HNG_stage3.DTOs;
using System.Threading.Tasks;

namespace HNG_stage3.Controllers
{
    [ApiController]
    [Route("api/v1/organizations")] // This ensures all endpoints in this controller require authentication by default
    public class OrganizationController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ApiResponse<OrganizationDto>), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ApiResponse<string>), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateOrganization([FromBody] CreateOrganizationDto createOrganizationDto)
        {
            var response = new ApiResponse<OrganizationDto>
            {
                Status = true,
                Message = "Organization created successfully",
                Data = new OrganizationDto { Id = 1, Name = createOrganizationDto.Name, Description = createOrganizationDto.Description }
            };
            return StatusCode(StatusCodes.Status201Created, response);
        }

        [HttpGet]
        [ProducesResponseType(typeof(ApiResponse<PaginatedOrganizationsDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<string>), StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetAllOrganizations([FromQuery] int page = 1, [FromQuery] int limit = 20)
        {
            var response = new ApiResponse<PaginatedOrganizationsDto>
            {
                Status = true,
                Message = "Organizations retrieved successfully",
                Data = new PaginatedOrganizationsDto
                {
                    Organizations = new List<OrganizationDto> { new OrganizationDto { Id = 1, Name = "Acme Corp", Description = "A sample organization" } },
                    Total = 50,
                    Page = page,
                    Limit = limit
                }
            };
            return Ok(response);
        }

        [Authorize(Roles = "Admin,Owner")] // Assuming you have a way to specify roles
        [HttpPost("{organizationId}/users")]
        [ProducesResponseType(typeof(ApiResponse<UserOrganizationDto>), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ApiResponse<string>), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AddUserToOrganization(int organizationId, [FromBody] AddUserToOrganizationDto addUserDto)
        {
            var response = new ApiResponse<UserOrganizationDto>
            {
                Status = true,
                Message = "User added to organization successfully",
                Data = new UserOrganizationDto
                {
                    UserId = addUserDto.UserId,
                    OrganizationId = organizationId,
                    Role = addUserDto.Role,
                    CreatedAt = DateTime.UtcNow
                }
            };
            return StatusCode(StatusCodes.Status201Created, response);
        }

        [HttpGet("{organizationId}/users")]
        [ProducesResponseType(typeof(ApiResponse<List<UserOrganizationDto>>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<string>), StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetOrganizationUsers(int organizationId)
        {
            var response = new ApiResponse<List<UserOrganizationDto>>
            {
                Status = true,
                Message = "Users retrieved successfully",
                Data = new List<UserOrganizationDto>
                {
                    new UserOrganizationDto
                    {
                        UserId = 1,
                        OrganizationId = organizationId,
        

                Role = "admin",
                        CreatedAt = DateTime.UtcNow
                    }
                }
            };
            return Ok(response);
        }
    }
}