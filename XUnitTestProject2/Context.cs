using Forum.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace XUnitTestProject
{
    class Context : ApplicationDbContext
    {
        
        public Context(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("test");
        }

        public Task SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }
        
    }
}
