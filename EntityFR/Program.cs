using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFR.Models;
using EntityFR.Repositories;

namespace EntityFR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new MyContext();
            var repo = new ContactRepository(context);
            var c1 = new Contact() { Name = "Amadou" };
            var c2 = new Contact() { Name = "Kadialy" };

            repo.Insert(c1);
            repo.Insert(c2);
            
            Console.WriteLine(repo.GetAll());
            Console.ReadLine();
            
        }
    }
}
