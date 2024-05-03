using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuestionProjectCore.Repository;
using QuestionProjectCore.Repository.Main;

namespace QuestionProjectCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminListController : Controller
    {
        private readonly UserManager<IdentityUser> _user;

        public AdminListController(UserManager<IdentityUser> user)
        {
            _user = user;
        }       

        public async Task<IActionResult> Index()
        {
            var _users = await _user.Users.ToListAsync();
            return View(_users);
        }
    }
}
