using LogBook.BusinessLayer.Entities;
using LogBook.BusinessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBook.BusinessLayer.Service
{
    public class PersonService
    {
        private PersonRepository _personQuery;


        public PersonService()
        {
            _personQuery = new PersonRepository();

        }

        public List<Person> GetAll()
        {
            return _personQuery.SelectAll().ToList();
        }

        public int PostPerson(Person data)
        {
            return _personQuery.Insert(data);
        }

        public int UpdatePerson(Person data)
        {
            return _personQuery.Update(data);
        }

        public int DeletePerson(int id)
        {
            return _personQuery.Delete(id);
        }
    }
}
