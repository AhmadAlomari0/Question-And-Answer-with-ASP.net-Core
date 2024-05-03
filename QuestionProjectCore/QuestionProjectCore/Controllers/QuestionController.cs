using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using QuestionProjectCore.Models;
using QuestionProjectCore.Repository.Main;
using System.Security.Claims;

namespace QuestionProjectCore.Controllers
{
    public class QuestionController : Controller
    {
        public QuestionController(IUnitOfWork unitOfWork, UserManager<IdentityUser> user)
        {
            _unitOfWork = unitOfWork;
            _user = user;
        }
        private IUnitOfWork _unitOfWork;
        private UserManager<IdentityUser> _user;
        public async Task <IActionResult> Index()
        {
            var question = await _unitOfWork.questions.GetAllAsync();
            return View(question);
        }
        //Get
        public IActionResult WriteAQuestion()
        {
            return View();
        }
        [HttpPost]
        public void WriteQuestion(Question question)
        {
            _unitOfWork.questions.Add(question);
            RedirectToAction("Index");
        }
    }
}
