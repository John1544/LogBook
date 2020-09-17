using LogBook.BusinessLayer.Entities;
using LogBook.BusinessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBook.BusinessLayer.Service
{
    public class LogsService
    {
        //task
        private LogRepository _logQuery;


        public LogsService()
        {
            _logQuery = new LogRepository();

        }

        public List<Logs> GetAll()
        {
            return _logQuery.SelectAll().ToList();
        }

        public int Add(Logs data)
        {
            return _logQuery.Insert(data);
        }

        public int Update(Logs data)
        {
            return _logQuery.Update(data);
        }

        public int Delete(int id)
        {
            return _logQuery.Delete(id);
        }
    }
}
