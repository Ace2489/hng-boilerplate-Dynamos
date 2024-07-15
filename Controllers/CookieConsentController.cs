using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using HNG_stage3.DTOs;

namespace HNG_stage3.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/v1/cookie-consent")]
    public class CookieConsentController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(CookieConsentDto), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(object), StatusCodes.Status401Unauthorized)]
        public IActionResult SetCookieConsent([FromBody] SetCookieConsentDto setCookieConsentDto)
        {
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpGet]
        [ProducesResponseType(typeof(CookieConsentDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(object), StatusCodes.Status404NotFound)]
        public IActionResult GetCookieConsent()
        {
            return Ok();
        }

        [HttpPut]
        [ProducesResponseType(typeof(CookieConsentDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(object), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(object), StatusCodes.Status404NotFound)]
        public IActionResult UpdateCookieConsent([FromBody] SetCookieConsentDto updateCookieConsentDto)
        {
            return Ok();
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(object), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(object), StatusCodes.Status404NotFound)]
        public IActionResult DeleteCookieConsent()
        {
            return NoContent();
        }
    }
}