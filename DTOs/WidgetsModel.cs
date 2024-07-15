namespace HNG_stage3.DTOs
{
    public class AddUserWidgetDto
    {
        public string WidgetType { get; set; }
        public object Data { get; set; }
    }

    public class UpdateUserWidgetDto
    {
        public object Data { get; set; }
    }

    public class UserWidgetDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string WidgetType { get; set; }
        public object Data { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

    public class UserWidgetListDto
    {
        public List<UserWidgetDto> Data { get; set; }
        public int Total { get; set; }
        public int Page { get; set; }
        public int PerPage { get; set; }
    }

    public class WidgetTypeDto
    {
        public int Id { get; set; }
        public string WidgetType { get; set; }
    }

    public class WidgetTypeListDto
    {
        public List<WidgetTypeDto> Data { get; set; }
        public int Total { get; set; }
        public int Page { get; set; }
        public int PerPage { get; set; }
    }
}