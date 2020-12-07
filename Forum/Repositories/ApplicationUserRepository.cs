using Microsoft.EntityFrameworkCore;
using Forum.Data;
using Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Repositories
{
    public class ApplicationUserRepository : IApplicationUserRepository
    {
        private ApplicationDbContext _context;

        public ApplicationUserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public ApplicationUser CreateUser(ApplicationUser newUser)
        {
            //newUser.RoleType = "user";
            newUser.CreatedOn = DateTime.Now;
            _context.ApplicationUsers.Add(newUser);
            _context.SaveChanges();
            return newUser;
        }

        public ApplicationUser GetApplicationUser(string username)
        {
            return _context.ApplicationUsers.FirstOrDefault(m => m.UserName == username);
        }

        public ApplicationUser GetApplicationUserById(string id)
        {
            return _context.ApplicationUsers.FirstOrDefault(m => m.Id == id);
        }

        public ICollection<ApplicationUser> GetAllApplicationUsers()
        {
            ICollection<ApplicationUser> applicationUsers = _context.ApplicationUsers.ToList();
            return applicationUsers;
        }

        public ApplicationUser UpdateApplicationUser(ApplicationUser updatedCustomer, string u)
        {
            //ApplicationUser originalApplicationUser = _context.ApplicationUsers.FirstOrDefault(u => u.Id == updatedCustomer.Id);
            ApplicationUser originalApplicationUser = _context.ApplicationUsers.FirstOrDefault(m => m.UserName == u);
            originalApplicationUser.name = updatedCustomer.name;
            originalApplicationUser.FirstName = updatedCustomer.FirstName;
            originalApplicationUser.LastName = updatedCustomer.LastName;
            originalApplicationUser.Address = updatedCustomer.Address;
            originalApplicationUser.City = updatedCustomer.City;
            originalApplicationUser.PhoneNumber = updatedCustomer.PhoneNumber;
            originalApplicationUser.Email = updatedCustomer.Email;

            _context.SaveChanges();
            return updatedCustomer;
        }

        public bool DeleteApplicationUser(string id)
        {
            var deletedCustomer = _context.ApplicationUsers.Find(id);
            if (deletedCustomer != null)
            {
                _context.ApplicationUsers.Remove(deletedCustomer);
                _context.SaveChanges();
            }
            return (_context.ApplicationUsers.Find(id) == null);
        }

        public ApplicationUser GetApplicationUserByUsername(string username)
        {
            return _context.ApplicationUsers.FirstOrDefault(m => m.UserName == username);
        }
    }
}
