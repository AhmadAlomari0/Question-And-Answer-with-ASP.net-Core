using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using QuestionProjectCore.Models;
using QuestionProjectCore.Repository.Main;
using System.Security.Claims;

namespace QuestionProjectCore.Controllers
{
    public class QuestionController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<ApplicationUser> _userManager;

        public QuestionController(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }


        public async Task <IActionResult> Index()
        {
            ViewBag.answers = await _unitOfWork.answer.GetAllAsync();
            var question = await _unitOfWork.questions.GetAllAsync();
            return View(question);
        }
        //Get
        public IActionResult WriteAQuestion()
        {
            return View();
        }

        [HttpPost]
        public IActionResult WriteQuestion(Question question)
        {

                if (!string.IsNullOrWhiteSpace(question.TheQuestion))
                {
                    _unitOfWork.questions.Add(question);
                    //_unitOfWork.CommitChanges();
                    return RedirectToAction("Index");
                }
            return RedirectToAction("WriteQuestion");


        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult WriteAnAnswer(Answer answer, int questionId)
        {

            if (!string.IsNullOrWhiteSpace(answer.TheAnswer))
            {
                var answers = new Answer
                {
                    TheAnswer = answer.TheAnswer,
                    QuestionID = questionId,
                    UserId = answer.UserId,
                    Like = answer.Like
                };

                _unitOfWork.answer.Add(answers);

                return RedirectToAction("Index");
            }
            return RedirectToAction("WriteAnswer");
        }
        //GET
        public IActionResult WriteAnAnswer(int questionId)
        {
            ViewData["questionId"] = questionId;
            return View();
        }
    }
}
