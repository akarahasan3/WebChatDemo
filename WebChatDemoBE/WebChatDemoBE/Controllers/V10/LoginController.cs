using Microsoft.AspNetCore.Mvc;
using WebChatDemoBE.Models;

namespace WebChatDemoBE.Controllers
{
    [ApiController]
    [Route("{version}/[controller]")]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public IActionResult Login([FromBody] LoginModel user)
        {
            return Ok();
        }
        
    }
}