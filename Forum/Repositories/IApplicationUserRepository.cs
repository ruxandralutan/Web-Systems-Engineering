using System.Collections.Generic;
using Forum.Models;

namespace Forum.Repositories
{
    public interface IApplicationUserRepository
    {
        bool DeleteApplicationUser(string username);
        ICollection<ApplicationUser> GetAllApplicationUsers();
        ApplicationUser GetApplicationUser(string username);
        ApplicationUser UpdateApplicationUser(ApplicationUser updatedCustomer, string u);
        ApplicationUser GetApplicationUserById(string id);
    }
}