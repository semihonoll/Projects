namespace _74_MVC_EventProject.Models
{
    public class AppEventDetail
    {
        public int EventId { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public string Photo { get; set; }
        public double Price { get; set; }

        public virtual AppEvent AppEvent { get; set; }
    }
}
