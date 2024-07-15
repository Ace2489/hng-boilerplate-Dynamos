using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using HNG_stage3.Helpers;
using HNG_stage3.DTOs;

namespace HNG_stage3.Controllers
{
    [ApiController]
    [Route("api/v1/auth")]
    public class AuthController : ControllerBase
    {
        [AllowAnonymous]
        [HttpPost("register")]
        [ProducesResponseType(typeof(UserDto), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(GenericErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(GenericErrorResponse), StatusCodes.Status422UnprocessableEntity)]
        [ProducesResponseType(typeof(GenericErrorResponse), StatusCodes.Status409Conflict)]
        public async Task<IActionResult> Register([FromBody] RegisterUserDto registerUserDto)
        {
            return StatusCode(StatusCodes.Status201Created, new UserDto());
        }

        [AllowAnonymous]
        [HttpPost("login")]
        [ProducesResponseType(typeof(AuthResponseDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(GenericErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(GenericErrorResponse), StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Login([FromBody] LoginUserDto loginUserDto)
        {
            return Ok(new AuthResponseDto());
        }

        [AllowAnonymous]
        [HttpPost("logout")]
        [ProducesResponseType(typeof(GenericSuccessResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(GenericErrorResponse), StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Logout()
        {
            return Ok(new GenericSuccessResponse { Message = "Successfully logged out" });
        }

        [AllowAnonymous]
        [HttpGet("{provider}")]
        [ProducesResponseType(StatusCodes.Status302Found)]
        [ProducesResponseType(typeof(GenericErrorResponse), StatusCodes.Status400BadRequest)]
        public IActionResult SocialAuthInitiate(string provider)
        {
            return RedirectPermanent($"https://{provider}.com/oauth");
        }

        [AllowAnonymous]
        [HttpGet("{provider}/callback")]
        [ProducesResponseType(StatusCodes.Status302Found)]
        [ProducesResponseType(typeof(GenericErrorResponse), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> SocialAuthCallback(string provider, [FromQuery] string code, [FromQuery] string state)
        {
            return RedirectPermanent($"https://yourfrontend.com/auth?token=placeholder");
        }


        [AllowAnonymous]
        [HttpPost("forgot-password")]
        [ProducesResponseType(typeof(GenericSuccessResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(GenericErrorResponse), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordDto forgotPasswordDto)
        {
            return Ok(new GenericSuccessResponse { Message = "Password reset email sent" });
        }

        [AllowAnonymous]
        [HttpPost("reset-password")]
        [ProducesResponseType(typeof(GenericSuccessResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(GenericErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(GenericErrorResponse), StatusCodes.Status422UnprocessableEntity)]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordDto resetPasswordDto)
        {
            return Ok(new GenericSuccessResponse { Message = "Password successfully reset" });
        }

        
        [HttpPut("change-password")]
        [ProducesResponseType(typeof(GenericSuccessResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(GenericErrorResponse), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(GenericErrorResponse), StatusCodes.Status422UnprocessableEntity)]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordDto changePasswordDto)
        {
            return Ok(new GenericSuccessResponse { Message = "Password successfully changed" });
        }
    }
}