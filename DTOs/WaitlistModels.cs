namespace HNG_stage3.DTOs
{
    public class CreateWaitlistEntryDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string? Notes { get; set; }
    }

    public class UpdateWaitlistEntryDto
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Email { get; set; }
        public string? Status { get; set; }
        public DateTime? InvitedAt { get; set; }
        public string? Notes { get; set; }
    }

    public class WaitlistEntryDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public DateTime? InvitedAt { get; set; }
        public string? Notes { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

    public class WaitlistEntriesListDto
    {
        public List<WaitlistEntryDto> Data { get; set; }
        public int Total { get; set; }
        public int Page { get; set; }
        public int PerPage { get; set; }
    }
}