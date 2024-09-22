namespace _74_MVC_EventProject.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public virtual ICollection<AppEvent> AppEvents { get; set; }
    }
}
