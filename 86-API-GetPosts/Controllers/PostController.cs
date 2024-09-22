using _86_API_GetPosts.Models;
using _86_API_GetPosts.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace _86_API_GetPosts.Controllers
{
    public class PostController : Controller
    {
        private readonly ApiServices _apiServices;

        public PostController(ApiServices apiServices)
        {
            _apiServices = apiServices;
        }

        public async Task<IActionResult> Index()
        {
            List<PostDb> posts = await _apiServices.GetApiAllPosts();

            if(posts == null || posts.Count == 0)
                return NotFound();

            return View(posts);
        }
    }
}
