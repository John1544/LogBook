using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBook.BusinessLayer.Repositories
{
    public abstract class BaseRepository<T> where T : class
    {

        public IDbConnection Connection { get; set; }
        public abstract string TableName { get; }

        public BaseRepository()
        {
            string connectString = (ConfigurationManager.ConnectionStrings["ConnectionStringConfig"].ConnectionString);//from appConfig.
            Connection = new SqlConnection(connectString);
        }
    }
}
