using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using HNG_stage3.DTOs;

namespace HNG_stage3.Controllers; 

[ApiController]
[Route("api/v1/users")]
public class UsersController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(UserResponseDto), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ErrorResponseDto), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponseDto), StatusCodes.Status409Conflict)]
    public IActionResult CreateUser([FromBody] CreateUserRequestDto request)
    {
        return StatusCode(201, new UserResponseDto());
    }

    [HttpGet("{id}")]
    [ProducesResponseType(typeof(UserResponseDto), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponseDto), StatusCodes.Status404NotFound)]
    public IActionResult GetUser([FromRoute] int id)
    {
        return Ok(new UserResponseDto());
    }

    [HttpPut("{id}")]
    [ProducesResponseType(typeof(UpdateUserResponseDto), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponseDto), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponseDto), StatusCodes.Status404NotFound)]
    public IActionResult UpdateUser([FromRoute] int id, [FromBody] UpdateUserRequestDto request)
    {
        return Ok(new UpdateUserResponseDto());
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ErrorResponseDto), StatusCodes.Status404NotFound)]
    public IActionResult DeleteUser([FromRoute] int id)
    {
        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(typeof(UserListResponseDto), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponseDto), StatusCodes.Status400BadRequest)]
    public IActionResult ListUsers([FromQuery] int page = 1, [FromQuery] int per_page = 20)
    {
        return Ok(new UserListResponseDto());
    }
}