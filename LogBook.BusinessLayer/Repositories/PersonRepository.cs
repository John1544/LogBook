using Dapper;
using LogBook.BusinessLayer.Entities;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBook.BusinessLayer.Repositories
{
    internal class PersonRepository : BaseRepository<Person>
    {
        public override string TableName => "Person";
        

    }
}
