using Dapper;
using ExamenNet.DTO;
using ExamenNet.Repositories;
using Npgsql;


namespace ExamenNet.DataAccess
{
    public class LoginRepository : Repository<UserDTO>, ILoginRepository
    {
        public LoginRepository(string connectionString) : base(connectionString)
        {

        }
        public UserDTO ValidateUser(string email, string password)
        {
            string query = " SELECT id, " +
                            " user_name, " +
                            " pwd " +
                            " FROM public.users " +
                            " where user_name='" + email + "' " +
                            " and pwd = '" + password + "';";
            using (var connection = new NpgsqlConnection(this._connectionString))
            {
                return connection.QueryFirstOrDefault<UserDTO>(query, null, commandType: System.Data.CommandType.Text);
            }

        }
    }
}
