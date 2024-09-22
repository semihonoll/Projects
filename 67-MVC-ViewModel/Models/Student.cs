namespace _67_MVC_ViewModel.Models
{
    public class Student
    {
        public string Id { get; set; } = Guid.NewGuid().ToString().Substring(1, 5);
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true;

        //Navigation
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}
