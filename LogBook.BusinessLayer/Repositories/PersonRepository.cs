using Dapper;
using LogBook.BusinessLayer.Entities;
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

        public List<Person> Select()
        {
            string sql = $"SELECT FirstName, LastName From {TableName}";
            return Connection.Query<Person>(sql).ToList();
        }

        public int Insert(Person data)
        {
            try
            {
                List<string> columns = data.GetType().GetProperties().Where(wherePerson => wherePerson.Name.ToLower() != "Id").Select(selectPerson => selectPerson.Name).ToList();
                List<string> values = data.GetType().GetProperties().Where(wherePerson => wherePerson.Name.ToLower() != "Id").Select(selectPerson => selectPerson.GetValue(data).ToString()).ToList();
                string sql = $"INSERT INTO { TableName } ({string.Join(",", columns)}); VALUES({string.Join(",", values)}); ";
                return Connection.Execute(sql);
            }
            catch (Exception)
            {
                //logger
                return -1;
            }
        }

        public int Update(Person data)
        {
            try
            {
                List<string> columns = data.GetType().GetProperties().Where(wherePerson => wherePerson.Name.ToLower() != "Id").Select(selectPerson => selectPerson.Name).ToList();
                List<string> values = data.GetType().GetProperties().Where(wherePerson => wherePerson.Name.ToLower() != "Id").Select(selectPerson => selectPerson.GetValue(data).ToString()).ToList();
                string sql = $"UPDATE {TableName}.Id SET Id = ({string.Join(",", columns)}); WHERE ({string.Join(",", values)});";
                return Connection.Execute(sql);
            }
            catch (Exception)
            {
                //Logger
                return -1;
            }
        }
        public int Delete(Person data)
        {
            try
            {
                List<string> columns = data.GetType().GetProperties().Where(wherePerson => wherePerson.Name.ToLower() != "Id").Select(selectPerson => selectPerson.Name).ToList();
                List<string> values = data.GetType().GetProperties().Where(wherePerson => wherePerson.Name.ToLower() != "Id").Select(selectPerson => selectPerson.GetValue(data).ToString()).ToList();
                string sql = $"Delete FROM {TableName}.Id WHERE Id = ({string.Join(",", columns)}); ({string.Join(",", values)});";
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
