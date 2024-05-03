using Microsoft.AspNetCore.Mvc;
using QuestionProjectCore.Models;

namespace QuestionProjectCore.Controllers
{
    public class QuestionsController : Controller
    {
        private readonly AppDbContext _db;
        public QuestionsController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Question> questions = _db.Questions;
            return View(questions);
        }
    }
}
