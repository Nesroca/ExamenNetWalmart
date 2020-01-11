using ExamenNet.DTO;
using ExamenNet.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ExamenNet.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IExamenDBUnitOfWork _unitOfWork;
        public ProductController(IExamenDBUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route("{Products}")]
        public List<ProductDTO> GetProducts()
        {
            return this._unitOfWork.Product.GetProducts().ToList();
        }
    }
}