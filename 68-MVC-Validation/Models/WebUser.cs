namespace _68_MVC_Validation.Models
{
    public class WebUser
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }=true;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
