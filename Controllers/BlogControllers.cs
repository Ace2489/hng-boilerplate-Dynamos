using Microsoft.AspNetCore.Mvc;
using HNG_stage3.DTOs;

namespace HNG_stage3.Controllers
{
    [ApiController]
    [Route("api/v1/blog-posts")]
    public class BlogPostsController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(BlogPostDto), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(object), StatusCodes.Status401Unauthorized)]
        public IActionResult CreateBlogPost([FromBody] CreateBlogPostDto createBlogPostDto)
        {
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(BlogPostDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(object), StatusCodes.Status404NotFound)]
        public IActionResult GetBlogPost([FromRoute] int id)
        {
            return Ok();
        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(BlogPostDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(object), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(object), StatusCodes.Status404NotFound)]
        public IActionResult UpdateBlogPost([FromRoute] int id, [FromBody] UpdateBlogPostDto updateBlogPostDto)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(object), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(object), StatusCodes.Status404NotFound)]
        public IActionResult DeleteBlogPost([FromRoute] int id)
        {
            return NoContent();
        }

        [HttpGet]
        [ProducesResponseType(typeof(BlogPostListDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(object), StatusCodes.Status401Unauthorized)]
        public IActionResult ListBlogPosts(
            [FromQuery] int page = 1, 
            [FromQuery] int per_page = 20, 
            [FromQuery] string? status = null, 
            [FromQuery] int? author_id = null)
        {
            return Ok();
        }
    }
}