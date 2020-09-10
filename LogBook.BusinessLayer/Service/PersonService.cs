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
        private PersonRepository _selectPerson;
        private PersonRepository _insertPerson;
        private PersonRepository _updatePerson;
        private PersonRepository _deletePerson;

        public PersonService()
        {
            _selectPerson = new PersonRepository();
            _insertPerson = new PersonRepository();
            _updatePerson = new PersonRepository();
            _deletePerson = new PersonRepository();
        }

        public List<Person> GetAll()
        {
            return _selectPerson.SelectAll().ToList();
            return _selectPerson.SelectAll().ToList();
        }

        public int PostPerson(Person data)
        {
            return _insertPerson.Insert(data);
        }

        public int UpdatePerson(Person data)
        {
            return _updatePerson.Update(data);
        }

        public int DeletePerson(int id)
        {
            return _deletePerson.Delete(id);
        }
    }
}
