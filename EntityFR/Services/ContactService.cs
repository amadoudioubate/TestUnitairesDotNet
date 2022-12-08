using EntityFR.Models;
using EntityFR.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFR.Services
{
    public class ContactService
    {
        private IContactRepository repo;

        public ContactService(IContactRepository contactRepository)
        {
            this.repo = contactRepository;
        }

        public void Delete(int id)
        {
            repo.Delete(id);
        }

        public List<Contact> GetAll()
        {
            return  repo.GetAll();
        }

        public Contact GetById(int id)
        {
            return repo.GetById(id);
        }

        public void Insert(Contact c)
        {
            repo.Insert(c);
        }

        public void Update(Contact c)
        {
            repo.Update(c);
        }
    }
}
