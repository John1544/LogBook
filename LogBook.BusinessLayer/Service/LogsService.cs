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
        private LogRepository _selectLogs;
        private LogRepository _insertLogs;
        private LogRepository _updateLogs;
        private LogRepository _deleteLogs;

        public LogsService()
        {
            _selectLogs = new LogRepository();
            _insertLogs = new LogRepository();
            _updateLogs = new LogRepository();
            _deleteLogs = new LogRepository();
        }

        public List<Logs> GetAll()
        {
            return _selectLogs.SelectAll().ToList();
        }
            
        public int Add(Logs data)
        {
            return _selectLogs.Insert(data);
        }

        public int Update(Logs data)
        {
            return _updateLogs.Update(data);
        }

        public int Delete(int id)
        {
            return _deleteLogs.Delete(id);
        }
    }
}
