using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace C_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [Route("/")]
        public String saludo()
        {
            return "Hola desde Lenguaje C#!!!!";
        }
    }
}
