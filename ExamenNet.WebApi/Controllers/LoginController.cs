using ExamenNet.DTO;
using ExamenNet.UnitOfWork;
using ExamenNet.WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExamenNet.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IExamenDBUnitOfWork _unitOfWork;
        public LoginController(IExamenDBUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        [HttpPost]
        [Route("{Login}")]
        public UserDTO Login([FromForm] LoginUser user)
        {
            return this._unitOfWork.Login.ValidateLoginUser(user.Correo, user.Password);
        }
    }
}