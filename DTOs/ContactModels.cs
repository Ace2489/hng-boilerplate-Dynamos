using System;
using System.ComponentModel.DataAnnotations;

namespace HNG_stage3.DTOs;

public class SubmitContactMessageRequestDto
{
    [Required]
    public string Name { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public string Subject { get; set; }

    [Required]
    public string Message { get; set; }
}

public class SubmitContactMessageResponseDto
{
    public int Id { get; set; }
    public string Message { get; set; }
    public string ReferenceNumber { get; set; }
}

public class ContactMessageStatusDto
{
    public string ReferenceNumber { get; set; }
    public string Status { get; set; }
    public DateTime CreatedAt { get; set; }
}

public class ContactMessageListItemDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Subject { get; set; }
    public string Status { get; set; }
    public DateTime CreatedAt { get; set; }
}

public class ContactMessageListResponseDto
{
    public int Total { get; set; }
    public int Page { get; set; }
    public int Limit { get; set; }
    public List<ContactMessageListItemDto> Messages { get; set; }
}

public class ContactMessageDetailDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Subject { get; set; }
    public string Message { get; set; }
    public string Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? RespondedAt { get; set; }
    public int? ResponderId { get; set; }
}

public class RespondToContactMessageRequestDto
{
    [Required]
    public string Response { get; set; }
}

public class RespondToContactMessageResponseDto
{
    public int Id { get; set; }
    public string Message { get; set; }
    public string Status { get; set; }
    public DateTime RespondedAt { get; set; }
}

public class UpdateContactMessageStatusRequestDto
{
    [Required]
    public string Status { get; set; }
}

public class UpdateContactMessageStatusResponseDto
{
    public int Id { get; set; }
    public string Message { get; set; }
    public string Status { get; set; }
}
