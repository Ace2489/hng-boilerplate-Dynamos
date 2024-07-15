using System.ComponentModel.DataAnnotations;

namespace HNG_stage3.DTOs
{
    public class CreateOrganizationDto
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class OrganizationDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class PaginatedOrganizationsDto
    {
        public List<OrganizationDto> Organizations { get; set; }
        public int Total { get; set; }
        public int Page { get; set; }
        public int Limit { get; set; }
    }

    public class AddUserToOrganizationDto
    {
        [Required]
        public int UserId { get; set; }
        [Required]
        public string Role { get; set; }
    }

    public class UserOrganizationDto
    {
        public int UserId { get; set; }
        public int OrganizationId { get; set; }
        public string Role { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class ApiResponse<T>
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }
}