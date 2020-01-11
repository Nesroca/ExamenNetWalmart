using ExamenNet.DTO;
using ExamenNet.Repositories;

namespace ExamenNet.DataAccess
{
    public class ProductRepository : Repository<ProductDTO>, IProductRepository
    {
        public ProductRepository(string connectionString) : base(connectionString)
        {

        }

    }
}
