using Microsoft.EntityFrameworkCore;
using Shop.Date.Models;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;


namespace Shop.Date //Commit test for git-Readme
{
    public class AppDBContent: DbContext 
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options) 
        { 
        
        }
        public DbSet<Car> Car { get; set; }
        public DbSet<Category> Category { get; set; }

    }
}
