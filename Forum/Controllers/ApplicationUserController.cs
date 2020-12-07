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
    public class ApplicationUserController : Controller
    {
        IApplicationUserRepository repo;

        public ApplicationUserController(ApplicationDbContext context)
        {
            repo = new ApplicationUserRepository(context);
        }

        // GET: ApplicationUsers
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            return View(repo.GetAllApplicationUsers());
        }

        // Details for other users
        // GET: ApplicationUsers/Details/5
        [Authorize(Roles = "Admin,User")]
        public IActionResult Details(string id)
        {
            var applicationUser = repo.GetApplicationUserById(id);
            if (applicationUser == null)
            {
                return NotFound();
            }

            return View(applicationUser);
        }

        // Details for the user that is authenticated
        [Authorize(Roles = "Admin,User")]
        public IActionResult LogInDetails()
        {
            string name = User.Identity.Name;
            var applicationUser = repo.GetApplicationUser(name);
            if (applicationUser == null)
            {
                return NotFound();
            }

            return View(applicationUser);
        }

        // GET: ApplicationUsers/Create
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }

        // GET: ApplicationUsers/Edit/5
        [Authorize(Roles = "Admin,User")]
        public IActionResult Edit()
        {

            string name = User.Identity.Name;

            var applicationUser = repo.GetApplicationUser(name);
            if (applicationUser == null)
            {
                return NotFound();
            }
            return View(applicationUser);
        }

        // POST: ApplicationUsers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,User")]
        public IActionResult Edit([Bind("name,FirstName,LastName,Address,City,PhoneNumber,Email")] ApplicationUser applicationUser)
        {
            string name = User.Identity.Name;
            if (ModelState.IsValid)
            {
                applicationUser = repo.UpdateApplicationUser(applicationUser, name);
                return RedirectToAction(nameof(LogInDetails));
            }
            return View(applicationUser);
        }

        // GET: ApplicationUsers/Delete/5
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicationUser = repo.GetApplicationUserById(id);
            if (applicationUser == null)
            {
                return NotFound();
            }

            return View(applicationUser);
        }


        // POST: ApplicationUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public IActionResult DeleteConfirmed(string id)
        {
            repo.DeleteApplicationUser(id);
            return RedirectToAction(nameof(Index));
        }


    }
}
