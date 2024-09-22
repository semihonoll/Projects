using _81_MVC_Role.Models.VMs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _81_MVC_Role.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AdminController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IActionResult> Index()
        {
            var users = _userManager.Users.ToList();

            var userViewModels = new List<UserListVM>();

            foreach (var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user);
                string roleName = null;
                foreach (var role in roles) 
                {
                    roleName += role + ", ";
                }

                userViewModels.Add(new UserListVM 
                { 
                    Id = user.Id,
                    UserName = user.UserName,
                    Email = user.Email,
                    RoleName =roleName
                });
            }

            return View(userViewModels);
        }

        [HttpGet]
        public async Task<IActionResult> AddRole(string UserId, string UserName)
        { 
            AddRoleVM addRoleVM = new AddRoleVM();
            addRoleVM.UserId = UserId;
            addRoleVM.UserName = UserName;
            addRoleVM.Roles  = _roleManager.Roles.ToList();
            return View(addRoleVM);
        }

        [HttpPost]
        public async Task<IActionResult> AddRole(string UserId, string RoleName, string? deneme)
        { 
            var user = await _userManager.FindByIdAsync(UserId);
            if (user is not null && !string.IsNullOrEmpty(RoleName))
            { 
                var result = await _userManager.AddToRoleAsync(user, RoleName);
                if(result.Succeeded)
                    return RedirectToAction("Index");
                return View();
            }
            return View();
        }

        public async Task<IActionResult> RoleList()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            return View(roles);
        }

        [HttpGet]
        public IActionResult RoleCreate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RoleCreate(string roleName)
        {
            if (!string.IsNullOrEmpty(roleName))
            { 
                var result = await _roleManager.CreateAsync(new IdentityRole(roleName));
                if (result.Succeeded) 
                { 
                    return RedirectToAction("RoleList");
                }
            }
            return View();
        }
    }
}
