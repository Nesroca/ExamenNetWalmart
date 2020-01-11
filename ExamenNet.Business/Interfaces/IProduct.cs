using ExamenNet.DTO;
using System.Collections.Generic;

namespace ExamenNet.Business.Interfaces
{
    public interface IProduct
    {
        public IEnumerable<ProductDTO> GetProducts();
    }
}
