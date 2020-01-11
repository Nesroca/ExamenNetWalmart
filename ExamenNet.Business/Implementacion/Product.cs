using ExamenNet.Business.Interfaces;
using ExamenNet.DataAccess;
using ExamenNet.DTO;
using ExamenNet.Repositories;
using System.Collections.Generic;

namespace ExamenNet.Business.Implementacion
{
    public class Product : Repository<ProductDTO>, IProduct
    {
        public IProductRepository ProductContext { get; private set; }
        public Product(string connectionString) : base(connectionString)
        {
            ProductContext = new ProductRepository(connectionString);
        }

        public IEnumerable<ProductDTO> GetProducts()
        {
            return ProductContext.GetList();
        }
    }
}
