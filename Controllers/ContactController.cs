using Microsoft.AspNetCore.Mvc;
using HNG_stage3.DTOs;
using Microsoft.AspNetCore.Authorization;

namespace HNG_stage3.controllers;

[ApiController]
[Route("api/v1")]
public class ContactController : ControllerBase
{
    [AllowAnonymous]
    [HttpPost("contact")]
    [ProducesResponseType(typeof(SubmitContactMessageResponseDto), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ErrorResponseDto), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponseDto), StatusCodes.Status422UnprocessableEntity)]
    public IActionResult SubmitContactMessage([FromBody] SubmitContactMessageRequestDto request)
    {
        return StatusCode(201, new SubmitContactMessageResponseDto());
    }

    [AllowAnonymous]
    [HttpGet("contact/{referenceNumber}")]
    [ProducesResponseType(typeof(ContactMessageStatusDto), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponseDto), StatusCodes.Status404NotFound)]
    public IActionResult GetContactMessageStatus(string referenceNumber)
    {
        return Ok(new ContactMessageStatusDto());
    }
}

[ApiController]
[Route("api/v1/admin/contact")]
public class AdminContactController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(ContactMessageListResponseDto), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponseDto), StatusCodes.Status401Unauthorized)]
    public IActionResult ListContactMessages([FromQuery] string status, [FromQuery] int page = 1, [FromQuery] int limit = 20)
    {
        return Ok(new ContactMessageListResponseDto());
    }

    [HttpGet("{id}")]
    [ProducesResponseType(typeof(ContactMessageDetailDto), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponseDto), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorResponseDto), StatusCodes.Status404NotFound)]
    public IActionResult GetContactMessageDetails(int id)
    {
        return Ok(new ContactMessageDetailDto());
    }

    [HttpPost("{id}/respond")]
    [ProducesResponseType(typeof(RespondToContactMessageResponseDto), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponseDto), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorResponseDto), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorResponseDto), StatusCodes.Status422UnprocessableEntity)]
    public IActionResult RespondToContactMessage(int id, [FromBody] RespondToContactMessageRequestDto request)
    {
        return Ok(new RespondToContactMessageResponseDto());
    }

    [HttpPatch("{id}/status")]
    [ProducesResponseType(typeof(UpdateContactMessageStatusResponseDto), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponseDto), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorResponseDto), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(ErrorResponseDto), StatusCodes.Status422UnprocessableEntity)]
    public IActionResult UpdateContactMessageStatus(int id, [FromBody] UpdateContactMessageStatusRequestDto request)
    {
        return Ok(new UpdateContactMessageStatusResponseDto());
    }
}