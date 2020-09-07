using LogBook.BusinessLayer.Entities;
using LogBook.BusinessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBook.BusinessLayer.Service
{
    public class SelectPersonService
    {
        private PersonRepository _repository;

        public SelectPersonService()
        {
            _repository = new PersonRepository();
        }

        public List<Person> GetAll()
        {
            return _repository.Select().ToList();
        }
    }

}
