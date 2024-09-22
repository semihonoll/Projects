namespace _74_MVC_EventProject.Models
{
    public class AppEvent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public int CategoryId { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public virtual Category Category { get; set; }
        public virtual AppEventDetail AppEventDetail { get; set; }
    }
}
