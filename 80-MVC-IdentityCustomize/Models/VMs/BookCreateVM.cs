using _80_MVC_IdentityCustomize.Models.Enums;

namespace _80_MVC_IdentityCustomize.Models.VMs
{
    public class BookCreateVM
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public Status Status { get; set; }
    }
}
