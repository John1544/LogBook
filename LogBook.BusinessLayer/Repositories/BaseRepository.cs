using Dapper;
using LogBook.BusinessLayer.Entities;
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

        public List<T> Select()
        {
            string sql = $"SELECT FirstName, LastName From {TableName}";
            return Connection.Query<T>(sql).ToList();
        }

        public int Insert(T data)
        {
            try
            {
                List<string> columns = data.GetType().GetProperties().Where(whereBaseRepository => whereBaseRepository.Name.ToLower() != "Id").Select(selectBaseRepository => selectBaseRepository.Name).ToList();
                List<string> values = data.GetType().GetProperties().Where(whereBaseRepository => whereBaseRepository.Name.ToLower() != "Id").Select(selectBaseRepository => selectBaseRepository.GetValue(data).ToString()).ToList();
                string sql = $"INSERT INTO { TableName } ({string.Join(",", columns)}); VALUES({string.Join(",", values)}); ";
                return Connection.Execute(sql);
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
                List<string> columns = data.GetType().GetProperties().Where(whereBaseRepository => whereBaseRepository.Name.ToLower() != "Id").Select(selectBaseRepositoryselectBaseRepository => selectBaseRepositoryselectBaseRepository.Name).ToList();
                List<string> values = data.GetType().GetProperties().Where(whereBaseRepository => whereBaseRepository.Name.ToLower() != "Id").Select(selectBaseRepositoryselectBaseRepository => selectBaseRepositoryselectBaseRepository.GetValue(data).ToString()).ToList();
                string sql = $"UPDATE {TableName} SET ({string.Join(",", columns)}); VALUES ({string.Join(",", values)}); WHERE Id = Id";
                return Connection.Execute(sql);
            }
            catch (Exception)
            {
                //Logger
                return -1;
            }
        }
        public int Delete(T data)
        {
            try
            {
                List<string> columns = data.GetType().GetProperties().Where(whereBaseRepository => whereBaseRepository.Name.ToLower() != "Id").Select(selectBaseRepository => selectBaseRepository.Name).ToList();
                List<string> values = data.GetType().GetProperties().Where(whereBaseRepository => whereBaseRepository.Name.ToLower() != "Id").Select(selectBaseRepository => selectBaseRepository.GetValue(data).ToString()).ToList();
                string sql = $"Delete FROM {TableName} WHERE Id = ({string.Join(",", columns)}); ({string.Join(",", values)});";
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
