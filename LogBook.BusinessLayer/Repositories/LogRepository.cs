using LogBook.BusinessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBook.BusinessLayer.Repositories
{
    public class LogRepository : BaseRepository<Logs>
    {
        public override string TableName => "Logs";

    }
}
