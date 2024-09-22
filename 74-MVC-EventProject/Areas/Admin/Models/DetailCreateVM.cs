namespace _74_MVC_EventProject.Areas.Admin.Models
{
    public class DetailCreateVM
    {
        public int EventId { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public string Photo { get; set; }
        public double Price { get; set; }
    }
}
