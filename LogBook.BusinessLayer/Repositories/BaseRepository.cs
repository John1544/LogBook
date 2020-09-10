using Dapper;
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
        //strictly for inheritance cannot create a obeject
    {

        public IDbConnection Connection { get; set; }
        public abstract string TableName { get; }

        public BaseRepository()
        {
            string connectString = (ConfigurationManager.ConnectionStrings["ConnectionStringConfig"].ConnectionString);//from appConfig.
            Connection = new SqlConnection(connectString);
        }

        public List<T> SelectAll()
        {
            string sql = $"SELECT * FROM { TableName}";
            return Connection.Query<T>(sql).ToList();
        }

        public int Insert(T data)
        {
            try
            {
                //assignment where and select
                List<string> columns = data.GetType().GetProperties().Where(k => k.Name.ToLower() != "Id").Select(a => a.Name).ToList();
                List<string> values = data.GetType().GetProperties().Where(k => k.Name.ToLower() != "Id").Select(a => a.GetValue(data).ToString()).ToList();
                string sql = $"INSERT INTO { TableName } ({string.Join(",", columns)}); VALUES ({string.Join(",", values)}); ";
                return Connection.Execute(sql);
                //return primary key
            }
            catch (Exception)
            {
                //Logger
                return -1;
            }
        }

        public int Update(T data)
        {
            try
            {
                List<string> columns = data.GetType().GetProperties().Where(k => k.Name.ToLower() != "Id").Select(a => a.Name).ToList();
                List<string> values = data.GetType().GetProperties().Where(ka => ka.Name.ToLower() != "Id").Select(a => a.GetValue(data).ToString()).ToList();
                string sql = $"UPDATE {TableName} SET ({string.Join(",", columns)}); = ({string.Join(",", values)}); WHERE Id = ({string.Join(",", values)});";
                return Connection.Execute(sql);
                //return number rows affected
            }
            catch (Exception)
            {
                //Logger
                return -1;
            }
        }
        public int Delete(int id)
        {
            try
            {
                //array of Id's and will delete array will be use, one query to delete it all no for loop only one query
                string sql = $"Delete FROM {TableName} WHERE Id = {id};";
                return Connection.Execute(sql);

            }
            catch (Exception)
            {
                //logger
                return -1;
            }
        }
    }
}
