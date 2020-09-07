using LogBook.BusinessLayer.Entities;
using LogBook.BusinessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBook.BusinessLayer.Service
{
    public class DeletePersonService
    {
        private PersonRepository _delete;

        public DeletePersonService()
        {
            _delete = new PersonRepository();
        }

        public int UpdatePerson(Person data)
        {
            return _delete.Update(data);
        }
    }
}
