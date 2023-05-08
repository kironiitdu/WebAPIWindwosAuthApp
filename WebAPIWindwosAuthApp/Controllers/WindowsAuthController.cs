using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIWindwosAuthApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WindowsAuthController : ControllerBase
    {
        [HttpGet("GetUserWindowsUserName")]
        public IActionResult GetUserWindowsUserName()
        {
            string gettingWindowsUser = HttpContext.User.Identity?.Name!;
            var responseMessage = string.Format("Current Windows User Name: {0}", gettingWindowsUser);
            return Ok(responseMessage);
        }
    }
}
