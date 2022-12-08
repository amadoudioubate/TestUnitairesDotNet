using EntityFR.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace EntityFR.Repositories
{
    public class MyContext : DbContext
    {
        
        public MyContext()
            : base("name=MyContext")
        {
        }

        public DbSet<Contact> Contacts { get; set;  }
       
    }

    
}