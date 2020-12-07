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
    public class PostsController : Controller
    {
        IPostRepository repo;
        private readonly ApplicationDbContext _context;

        public PostsController(ApplicationDbContext context)
        {
            repo = new PostRepository(context);
            _context = context;
        }

        // GET: Posts
        public IActionResult Index()
        {
            string name = User.Identity.Name;
            return View(repo.GetAllPosts());
        }


        // GET: Posts/Details/5
        public IActionResult Details(int id)
        {
            if (id < 0)
            {
                return NotFound();
            }

            Post post = repo.GetPost(id);
            if (post == null)
            {
                return NotFound();
            }
            return View(post);
        }

        // GET: Posts/Create
        //[Authorize(Roles = "Admin,User")]
        public IActionResult Create()
        {

            return View();
        }

        // POST: Posts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("PostId,Title,Content")] Post post)
        {
            if (ModelState.IsValid)
            {
                string name = User.Identity.Name;
                post = repo.CreatePost(post, name);
                return RedirectToAction(nameof(Index));
            }
            return View(post);
        }

        // GET: Posts/Edit/5
        [Authorize(Roles = "Admin,User")]
        public IActionResult Edit(int id)
        {
            if (id < 0)
            {
                return NotFound();
            }

            var post = repo.GetPost(id);
            if (post == null)
            {
                return NotFound();
            }
            return View(post);
        }

        // POST: Posts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,User")]
        public IActionResult Edit(int id, [Bind("PostId,Title,Content")] Post post)
        {
            if (id != post.PostId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                post = repo.UpdatePost(post);
                return RedirectToAction(nameof(Index));
            }
            return View(post);
        }

        // GET: Posts/Delete/5
        [Authorize(Roles = "Admin,User")]
        public IActionResult Delete(int id)
        {
            if (id < 0)
            {
                return NotFound();
            }

            var post = repo.GetPost(id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        // POST: Posts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,User")]
        public IActionResult DeleteConfirmed(int id)
        {
            repo.DeletePost(id);
            return RedirectToAction(nameof(Index));
        }

        // GET: Posts
        public IActionResult Search(string searchString)
        {
            var strings = searchString.Split(' ');
            var finalPosts = new List<Post>();
            List<Post> posts = _context.Posts
                .Include(m => m.Comments).ThenInclude(m => m.User)
                .ToList();

            if (!String.IsNullOrEmpty(searchString))
            {
                foreach (var post in posts)
                {
                    bool match_title = true;
                    bool match_content = true;
                    foreach (var splitString in strings)
                    {
                        if (!post.Title.Contains(splitString, System.StringComparison.CurrentCultureIgnoreCase))
                            match_title = false;
                        if (!post.Content.Contains(splitString, System.StringComparison.CurrentCultureIgnoreCase))
                            match_content = false;
                    }
                    if (match_title == true || match_content == true)
                        finalPosts.Add(post);
                }
            }
            return View("Index", finalPosts);
        }

    }
}
