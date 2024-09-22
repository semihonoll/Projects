namespace _83_MVC_AutoMapper.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public DateTime? CreateDate { get; set; } = DateTime.Now;
        public DateTime? DeleteDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? Status { get; set; } = true;
    }
}
