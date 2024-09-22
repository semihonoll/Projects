using Microsoft.AspNetCore.Identity;

namespace _81_MVC_Role.Models.VMs
{
    public class AddRoleVM
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string RoleName { get; set; }
        public List<IdentityRole> Roles { get; set; }
    }
}
