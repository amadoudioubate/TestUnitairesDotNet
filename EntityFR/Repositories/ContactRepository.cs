using EntityFR.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityFR.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private MyContext _context = new MyContext();

        public ContactRepository(MyContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {

            try
            {
                var foundContact = _context.Contacts.Where(c => c.Id == id).SingleOrDefault();
                if (foundContact != null)
                {
                    _context.Contacts.Remove(foundContact);
                    _context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw new ArgumentException("Contact non trouvé");
            }
            
            
        }

        public List<Contact> GetAll()
        {
            return _context.Contacts.ToList();
        }

        public Contact GetById(int id)
        {
            return _context.Contacts.SingleOrDefault(c => c.Id == id);
        }

        public void Insert(Contact c)
        {
            _context.Contacts.Add(c);
            _context.SaveChanges();
        }

        public void Update(Contact c)
        {
            _context.Contacts.Attach(c);
            _context.Entry(c).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();

        }
    }
}
