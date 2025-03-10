using Microsoft.AspNetCore.Mvc;
using HotelManagement.Models;

namespace HotelManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost("SignUp")]
        public IActionResult SignUp([FromBody] SignUpModel model)
        {
            // Now model.FullName, model.Username, model.Email, model.Password are available
            return Ok(new { success = true, message = "User registered!" });
        }

        //  vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv
        //  INSERT THE TestRoute METHOD HERE - INSIDE THE AuthController CLASS, BUT OUTSIDE SignUp
        //  vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv
        [HttpGet("TestRoute")]
        public IActionResult TestRoute()
        {
            return Ok(new { message = "Test route is working!" });
        }
        //  ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        //  ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
    }
}