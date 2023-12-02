using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MultipleAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        //[HttpGet]
        //[Authorize]
        //[Route("/GetResult")]
        //public IActionResult Show()
        //{
        //    return Ok("Showing the Result");
        //}
    }
}
