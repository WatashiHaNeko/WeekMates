using Microsoft.AspNetCore.Mvc;
using WeekMates.ApiServer.Models.Requests;

namespace WeekMates.ApiServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : Controller
    {
        [HttpPost("signup")]
        public JsonResult SignUp(UsersSignUpRequest request)
        {
            return Json(new {
                Success = true,
                ErrorCode = "0",
                Data = new {},
            });
        }
    }
}
