using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Forum.Data;
using Forum.Models;
using Forum.Repositories;
using Microsoft.AspNetCore.Authorization;

namespace Forum.Controllers
{
    public class CommentsController : Controller
    {
        CommentRepository repo;
        private int tempPostId = 0;

        public CommentsController(ApplicationDbContext context)
        {
            repo = new CommentRepository(context);
        }

        // GET: Comments
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            return View(repo.GetAllComments());
        }

        // GET: Comments/Details/5
        [Authorize(Roles = "Admin")]
        public IActionResult Details(int id)
        {
            if (id < 0)
            {
                return NotFound();
            }

            var comment = repo.GetComment(id);
            if (comment == null)
            {
                return NotFound();
            }

            return View(comment);
        }

        // GET: Comments/Create
        [Authorize(Roles = "Admin,User")]
        public IActionResult Create()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }

        // POST: Comments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,User")]
        public IActionResult Create([Bind("CommentId,Content")] Comment comment, int postId)
        {
            if (ModelState.IsValid)
            {
                string name = User.Identity.Name;
                comment = repo.CreateComment(comment, name, postId);
                return RedirectToAction("Details", "Posts", new { id = postId });
            }
            return View(comment);
        }

        // GET: Comments/Edit/5
        [Authorize(Roles = "Admin,User")]
        public IActionResult Edit(int id)
        {
            if (id < 0)
            {
                return NotFound();
            }

            var comment = repo.GetComment(id);
            if (comment == null)
            {
                return NotFound();
            }
            return View(comment);
        }

        // POST: Comments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,User")]
        public IActionResult Edit(int id, [Bind("CommentId,Content,CreatedOn")] Comment comment)
        {
            if (id != comment.CommentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                comment = repo.UpdateComment(comment);
                return RedirectToAction(nameof(Index));
            }
            return View(comment);
        }

        // GET: Comments/Delete/5
        [Authorize(Roles = "Admin,User")]
        public IActionResult Delete(int id, int postId)
        {
            tempPostId = postId;
            if (id < 0)
            {
                return NotFound();
            }

            var comment = repo.GetComment(id);
            if (comment == null)
            {
                return NotFound();
            }

            return View(comment);
        }

        // POST: Comments/Delete/5
        [Authorize(Roles = "Admin,User")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            repo.DeleteComment(id);
            //return RedirectToAction("Details", "Posts", new { id = tempPostId });
            return RedirectToAction("Index", "Posts");
        }
    }
}
