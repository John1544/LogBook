using LogBook.BusinessLayer.Entities;
using LogBook.BusinessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBook.BusinessLayer.Service
{
    public class InsertPersonService
    {
        private PersonRepository _insert;

        public InsertPersonService()
        {
            _insert = new PersonRepository();
        }

        public int PostPerson(Person data)
        {
            return _insert.Insert(data);
        }
    }
}
