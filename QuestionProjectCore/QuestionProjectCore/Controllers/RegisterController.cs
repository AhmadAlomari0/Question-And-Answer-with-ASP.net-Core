using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using QuestionProjectCore.Models;

namespace QuestionProjectCore.Controllers
{
    public class RegisterController : Controller
    {
        public RegisterController(AppDbContext db)
        {
            _db = db;
        }
        
        private readonly AppDbContext _db;

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Member member)
        {
            try
            {
                _db.Members.Add(member);
                _db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                string exMessage = ex.Message;
                    ViewData["Message"] = exMessage;

                return View();
            }
        }
    }
}
