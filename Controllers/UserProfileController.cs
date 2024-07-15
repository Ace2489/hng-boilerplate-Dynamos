using Microsoft.AspNetCore.Mvc;
using HNG_stage3.DTOs;

namespace HNG_stage3.controllers;

[ApiController]
[Route("api/v1/users")]
public class UserProfileController : ControllerBase
{
    [HttpGet("profile")]
    [ProducesResponseType(typeof(UserProfileResponseDto), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponseDto), StatusCodes.Status401Unauthorized)]
    public IActionResult GetUserProfile()
    {
        return Ok(new UserProfileResponseDto());
    }

    [HttpPut("profile")]
    [ProducesResponseType(typeof(UpdateUserProfileResponseDto), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponseDto), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponseDto), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorResponseDto), StatusCodes.Status422UnprocessableEntity)]
    public IActionResult UpdateUserProfile([FromBody] UpdateUserProfileRequestDto request)
    {
        return Ok(new UpdateUserProfileResponseDto());
    }

    [HttpPost("profile/avatar")]
    [ProducesResponseType(typeof(UpdateAvatarResponseDto), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponseDto), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponseDto), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorResponseDto), StatusCodes.Status413PayloadTooLarge)]
    public IActionResult UpdateAvatar(IFormFile avatar)
    {
        return Ok(new UpdateAvatarResponseDto());
    }

    [HttpGet("profile/notifications")]
    [ProducesResponseType(typeof(NotificationPreferencesDto), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponseDto), StatusCodes.Status401Unauthorized)]
    public IActionResult GetNotificationPreferences()
    {
        return Ok(new NotificationPreferencesDto());
    }

    [HttpPatch("profile/notifications")]
    [ProducesResponseType(typeof(UpdateNotificationPreferencesResponseDto), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponseDto), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponseDto), StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(ErrorResponseDto), StatusCodes.Status422UnprocessableEntity)]
    public IActionResult UpdateNotificationPreferences([FromBody] UpdateNotificationPreferencesRequestDto request)
    {
        return Ok(new UpdateNotificationPreferencesResponseDto());
    }

    [HttpGet("profile/localization")]
    [ProducesResponseType(typeof(LocalizationDataDto), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponseDto), StatusCodes.Status500InternalServerError)]
    public IActionResult GetLocalizationData()
    {
        return Ok(new LocalizationDataDto());
    }
}