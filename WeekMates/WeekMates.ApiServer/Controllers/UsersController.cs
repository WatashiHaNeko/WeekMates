using Microsoft.AspNetCore.Mvc;

namespace WeekMates.ApiServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : Controller
    {
        [HttpPost("signup")]
        public JsonResult SignUp()
        {
            return Json(new {
                Success = true,
                ErrorCode = "0",
                Data = new {},
            });
        }
    }
}
