using CITB517_WebApplication.Data;
using CITB517_WebApplication.Data.Models;
using CITB517_WebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace CITB517_WebApplication.Controllers
{
    public class CommentsController : Controller
    {
        public readonly ApplicationDbContext _context;
        public CommentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // POST: Comments/Create
        [HttpPost]
        public async Task<IActionResult> Create(HomeViewModel model)
        {
            if (!ModelState.IsValid) {

                return View();
            }

            var dbModel = new Comment {
                Text = model.Create.Text,
                UserName = model.Create.UserName,
                Date = DateTime.UtcNow
            };

            _context.Add(dbModel);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Home");
        }


        // POST: Comments/Delete/
        [HttpPost]
        public async Task<IActionResult> Delete(int id, string userId)
        {
            var commentsModel = await _context.Comments.FirstOrDefaultAsync(c=> c.Id == id);

            if (commentsModel == null) {
                return RedirectToAction("Index", "Home");
            }

            if (commentsModel.UserName == userId) {
                _context.Comments.Remove(commentsModel);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("Index", "Home");
        }

    }
}
