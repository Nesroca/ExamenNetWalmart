using ExamenNet.DTO;

namespace ExamenNet.Repositories
{
    public interface ILoginRepository
    {
        UserDTO ValidateUser(string email, string password);
    }
}
