
using System.ComponentModel.DataAnnotations;

namespace HNG_stage3.DTOs
{
    public class PaymentInitializeDto
    {
        [Required]
        public int UserId { get; set; }

        [Required]
        public int OrganizationId { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public string Currency { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }

    public class PaymentInitializeResponseDto
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public PaymentInitializeDataDto Data { get; set; }
    }

    public class PaymentInitializeDataDto
    {
        public int PaymentId { get; set; }
        public string AuthorizationUrl { get; set; }
        public string AccessCode { get; set; }
        public string Reference { get; set; }
    }

    public class PaymentVerifyResponseDto
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public PaymentDto Data { get; set; }
    }

    public class PaymentDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OrganizationId { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string Status { get; set; }
        public string Provider { get; set; }
        public string TransactionId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

    public class PaymentsQueryDto
    {
        public int? UserId { get; set; }
        public int? OrganizationId { get; set; }
        public string Status { get; set; }
        public int? Page { get; set; }
        public int? Limit { get; set; }
    }

    public class PaymentsListResponseDto
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public PaymentsListDataDto Data { get; set; }
    }

    public class PaymentsListDataDto
    {
        public List<PaymentDto> Payments { get; set; }
        public int Total { get; set; }
        public int Page { get; set; }
        public int Limit { get; set; }
    }

    public class ErrorResponseDto
    {
        public bool Status { get; set; }
        public string Message { get; set; }
    }
}