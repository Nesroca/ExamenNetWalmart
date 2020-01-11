using ExamenNet.DTO;

namespace ExamenNet.Business.Interfaces
{
    public interface ILogin
    {
        public UserDTO ValidateLoginUser(string email, string password);
    }
}
