using Microsoft.AspNetCore.Mvc;

namespace EasyCommerce.Users.Http.Controllers
{
    [Route("api/[controller]/[action]")]
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return Ok();
        }
    }
}
