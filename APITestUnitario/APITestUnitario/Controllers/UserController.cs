using APITestUnitario.Entities;
using Microsoft.AspNetCore.Mvc;

namespace APITestUnitario.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(User user)
        {
            var usuarioDB = new User("Lucas",19);

            if (usuarioDB.Nome == user.Nome && usuarioDB.Idade == user.Idade)
                return Ok();

            return BadRequest();
        }
    }
}
