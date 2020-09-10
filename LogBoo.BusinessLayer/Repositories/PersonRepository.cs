using LogBook.BusinessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBoo.BusinessLayer.Repositories
{
    internal class PersonRepository : BaseRepository<Person>
    {
        public override string TableName => "Person";

    }
}
