using Dapper.Contrib.Extensions;
using ExamenNet.Repositories;
using Npgsql;
using System.Collections.Generic;


namespace ExamenNet.DataAccess
{
    public class Repository<T> : IRepository<T> where T : class
    {

        protected string _connectionString;
        public Repository(string conecctionString)
        {
            this._connectionString = conecctionString;
        }

        public IEnumerable<T> GetList()
        {
            using (var connection = new NpgsqlConnection(this._connectionString))
            {
                return connection.GetAll<T>();
            }
        }
    }
}
