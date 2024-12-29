using Hamada.Models.Entity;
using Hamada.Repos.IRepo;
using Microsoft.AspNetCore.Mvc;

namespace Hamada.Controllers
{
    public class UsersController : Controller
    {
        private readonly users repo;
        public UsersController(users repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> Users()
        {
            var r = await repo.GetAllUsers();
            return View(r);
        }
     
        public async Task<IActionResult> create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> create(User use)
        {
            var u = repo.CreateUser(use);
            return RedirectToAction("Index");
        }

      
    }
}
