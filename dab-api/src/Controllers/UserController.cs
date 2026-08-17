using Microsoft.AspNetCore.Mvc;

namespace dab_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {

        [HttpGet]
        public string Get()
        {
            return "Hello world";
        }
    }
}
