
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCoreExample
{
    // getting started with entity tutorial:
    // https://docs.microsoft.com/en-us/ef/core/get-started/overview/first-app
    // inherit database class from DbContext (Context generally used to name database Class)
    public class StudentContext : DbContext
    {
        public StudentContext()
        {
        }
        //override class that directs where your database is located
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //set options to use sqlserver at specified location. Database= desired name of database.Localdb included with VS.
            //Trusted connection indicates our windows account should be used.
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EFCoreExample;Trusted_Connection=True;");
        }
        // classes added here will be automatically linked to database
        public DbSet<Student> Students { get; set; }
    }
}
