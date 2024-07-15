// HNG_stage3.DTOs/MessageDTOs.cs

using System;

namespace HNG_stage3.DTOs
{
    public class SendMessageDto
    {
        public int RecipientId { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }

    public class MessageSummaryDto
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public int SenderId { get; set; }
        public DateTime SentAt { get; set; }
        public DateTime? ReadAt { get; set; }
    }

    public class MessageDetailDto
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public int SenderId { get; set; }
        public int RecipientId { get; set; }
        public DateTime SentAt { get; set; }
        public DateTime? ReadAt { get; set; }
    }

    public class PaginatedMessagesDto
    {
        public List<MessageSummaryDto> Messages { get; set; }
        public int Total { get; set; }
        public int Page { get; set; }
        public int PerPage { get; set; }
    }

    public class MessageTemplateDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        public int AuthorId { get; set; }
    }

    public class MessageTemplateDetailDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public int AuthorId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }

    public class SendTemplateMessageDto
    {
        public int RecipientId { get; set; }
        public int TemplateId { get; set; }
        public object TemplateData { get; set; }
    }
}