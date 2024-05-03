using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using QuestionProjectCore.Models;
using QuestionProjectCore.Repository.Main;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace QuestionProjectCore.Controllers
{
    [Authorize(Roles = Roles.adminRole)]
    public class MembersController : Controller
    {
        private readonly IUnitOfWork _myUnit;
        private readonly IHostingEnvironment _host;
        public MembersController(IUnitOfWork myUnit, IHostingEnvironment host)
        {
            _myUnit = myUnit;
            _host = host;
        }

        string errorMessage = "There is something wrong !";

        public async Task<IActionResult> Index()
        {

            var oneCat = _myUnit.members.SelectOne(pn => pn.PhoneNumber == "0509488473");
            var allCat = await _myUnit.members.GetAllAsync("questions");
            //IEnumerable<member> membersList = _db.members.ToList();
            var membersList = await _myUnit.members.GetAllAsync();  
            return View(allCat);
        }
        //GET
        public IActionResult NewMember()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NewMember(Member member)
        {
            //membername custom error
            //if (member.memberName =="dd")
            //  ModelState.AddModelError("memberNameError","membername must be morethan 2 letters.");
            //PhoneNumber custom error
            // if (member.PhoneNumber.Length != 10 || member.PhoneNumber.Length != 12)
            //   ModelState.AddModelError("CustomError", "Phone number must be 10 or 12");

            //Check if value is valid

            try
            {

                if (CheckIsValid())
                {
                    string fileName = string.Empty;
                    if(member.ClientFile != null)
                    {
                        string myUpload = Path.Combine(_host.WebRootPath, "images");
                        fileName = member.ClientFile.FileName;
                        string fullPath = Path.Combine(myUpload, fileName);
                        member.ClientFile.CopyTo(new FileStream(fullPath, FileMode.Create));
                        member.ImagePath = fileName;
                    }
                    _myUnit.members.Add(member);
                    //_db.members.Add(member);
                    //_db.SaveChanges();

                    return RedirectToAction("Index");
                }
                else
                    return View();
            }
            catch
            {
                PassErrorMessage();
                return View();
            };
        }

        //GET
        public IActionResult EditMember(int? Id)
        {

            var member = _myUnit.members.GetByID(Id); //_db.members.Find(Id);
            //Check the ID doesn't equal zero or null and member doesn't equal null.
            if (CheckMember(Id, member))
                return View(member);
            else
                return NotFound();
        }

        private bool CheckMember(int? id=0, Member? member = null)
        {
            //Check if member and id both are equal null ? then return false
            if (id == null || id == 0 && member == null)
                    return false;
            else
                return true;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditMember(Member member)
        {
            //Check if value is valid
            try
            {
                if (CheckIsValid())
                {
                    _myUnit.members.Update(member);
                    //_db.members.Update(member);
                    //_db.SaveChanges();

                    return RedirectToAction("Index");
                }
                else
                    PassErrorMessage();
            }
            catch
            {
                PassErrorMessage();
                return View();
            };
            return View();
        }
        private void PassErrorMessage() => TempData["errorMessage"] = errorMessage;

        private bool CheckIsValid()
        {
                if (ModelState.IsValid)
                    return true;
                else
                    return false;
        }

        public IActionResult DeleteMember(int? Id)
        {
            if (CheckMember(Id))
            {
                var member = _myUnit.members.GetByID(Id); /*_db.members.FirstOrDefault(x => x.ID == Id);*/
                _myUnit.members.Delete(member);
                //_db.members.Remove(member);
                //_db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
                return NotFound();
        }
    }
}
