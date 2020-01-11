using ExamenNet.Business.Interfaces;
using ExamenNet.DataAccess;
using ExamenNet.DTO;
using ExamenNet.Repositories;

namespace ExamenNet.Business.Implementacion
{
    public class Login : Repository<UserDTO>, ILogin
    {
        public ILoginRepository LoginContext { get; private set; }
        public Login(string connectionString) : base(connectionString)
        {
            LoginContext = new LoginRepository(connectionString);
        }

        public UserDTO ValidateLoginUser(string email, string password)
        {
            return LoginContext.ValidateUser(email, password);
        }

    }
}
