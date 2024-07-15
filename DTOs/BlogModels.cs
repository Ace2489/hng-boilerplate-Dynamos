using System.ComponentModel.DataAnnotations;

namespace HNG_stage3.DTOs
{
    public class CreateBlogPostDto
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public string? Excerpt { get; set; }

        [Required]
        [RegularExpression("^(draft|published)$")]
        public string Status { get; set; }

        public DateTime? PublishedAt { get; set; }
    }

    public class UpdateBlogPostDto
    {
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? Excerpt { get; set; }
        [RegularExpression("^(draft|published)$")]
        public string? Status { get; set; }
        public DateTime? PublishedAt { get; set; }
    }

    public class BlogPostDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Content { get; set; }
        public string? Excerpt { get; set; }
        public string Status { get; set; }
        public int AuthorId { get; set; }
        public DateTime? PublishedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

    public class BlogPostSummaryDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string? Excerpt { get; set; }
        public string Status { get; set; }
        public int AuthorId { get; set; }
        public DateTime? PublishedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

    public class BlogPostListDto
    {
        public List<BlogPostSummaryDto> Data { get; set; }
        public int Total { get; set; }
        public int Page { get; set; }
        public int PerPage { get; set; }
    }
}