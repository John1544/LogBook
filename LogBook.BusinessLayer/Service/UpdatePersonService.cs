using LogBook.BusinessLayer.Entities;
using LogBook.BusinessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBook.BusinessLayer.Service
{
    public class UpdatePersonService
    {
        private PersonRepository _update;

        public UpdatePersonService()
        {
            _update = new PersonRepository();
        }

        public int UpdatePerson(Person data)
        {
            return _update.Update(data);
        }


    }
}
