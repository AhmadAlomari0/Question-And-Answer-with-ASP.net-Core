//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;
//using QuestionProjectCore;
//using QuestionProjectCore.Models;

//namespace QuestionProjectCore.Areas.Admin.Controllers
//{
//    [Area("Admin")]
//    public class ModeratorsController : Controller
//    {
//        private readonly AppDbContext _context;

//        public ModeratorsController(AppDbContext context)
//        {
//            _context = context;
//        }

//        // GET: Admin/Moderators
//        public async Task<IActionResult> Index()
//        {
//              return _context.Moderators != null ? 
//                          View(await _context.Moderators.ToListAsync()) :
//                          Problem("Entity set 'AppDbContext.Moderators'  is null.");
//        }

//        // GET: Admin/Moderators/Details/5
//        public async Task<IActionResult> Details(int? id)
//        {
//            if (id == null || _context.Moderators == null)
//            {
//                return NotFound();
//            }

//            var moderator = await _context.Moderators
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (moderator == null)
//            {
//                return NotFound();
//            }

//            return View(moderator);
//        }

//        // GET: Admin/Moderators/Create
//        public IActionResult Create()
//        {
//            return View();
//        }

//        // POST: Admin/Moderators/Create
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create([Bind("Id,ModeratorName,ModeratorPhone,Moderatormail,ModeratorAge,ModeratorSalary")] Moderator moderator)
//        {
//            if (ModelState.IsValid)
//            {
//                _context.Add(moderator);
//                await _context.SaveChangesAsync();
//                return RedirectToAction(nameof(Index));
//            }
//            return View(moderator);
//        }

//        // GET: Admin/Moderators/Edit/5
//        public async Task<IActionResult> Edit(int? id)
//        {
//            if (id == null || _context.Moderators == null)
//            {
//                return NotFound();
//            }

//            var moderator = await _context.Moderators.FindAsync(id);
//            if (moderator == null)
//            {
//                return NotFound();
//            }
//            return View(moderator);
//        }

//        // POST: Admin/Moderators/Edit/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(int id, [Bind("Id,ModeratorName,ModeratorPhone,Moderatormail,ModeratorAge,ModeratorSalary")] Moderator moderator)
//        {
//            if (id != moderator.Id)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    _context.Update(moderator);
//                    await _context.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!ModeratorExists(moderator.Id))
//                    {
//                        return NotFound();
//                    }
//                    else
//                    {
//                        throw;
//                    }
//                }
//                return RedirectToAction(nameof(Index));
//            }
//            return View(moderator);
//        }

//        // GET: Admin/Moderators/Delete/5
//        public async Task<IActionResult> Delete(int? id)
//        {
//            if (id == null || _context.Moderators == null)
//            {
//                return NotFound();
//            }

//            var moderator = await _context.Moderators
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (moderator == null)
//            {
//                return NotFound();
//            }

//            return View(moderator);
//        }

//        // POST: Admin/Moderators/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(int id)
//        {
//            if (_context.Moderators == null)
//            {
//                return Problem("Entity set 'AppDbContext.Moderators'  is null.");
//            }
//            var moderator = await _context.Moderators.FindAsync(id);
//            if (moderator != null)
//            {
//                _context.Moderators.Remove(moderator);
//            }
            
//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }

//        private bool ModeratorExists(int id)
//        {
//          return (_context.Moderators?.Any(e => e.Id == id)).GetValueOrDefault();
//        }
//    }
//}
