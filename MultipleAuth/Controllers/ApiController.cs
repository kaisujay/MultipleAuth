using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace MultipleAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        [Authorize]
        [HttpGet("getWithAny")]
        public IActionResult GetWithAny()
        {
            return Ok(new { Message = $"1 Hello to Code Maze {GetUsername()}" });
        }
        [HttpGet("getWithSecondJwt")]
        public IActionResult GetWithSecondJwt()
        {
            return Ok(new { Message = $"2 Hello to Code Maze {GetUsername()}" });
        }
        private string? GetUsername()
        {
            return HttpContext.User.Claims
                .Where(x => x.Type == ClaimTypes.Name)
                .Select(x => x.Value)
                .FirstOrDefault();
        }
    }
}
