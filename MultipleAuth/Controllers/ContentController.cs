﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace MultipleAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContentController : ControllerBase
    {
        //[HttpGet("getWithCookie")]
        //public IActionResult GetWithCookie()
        //{
        //    var userName = HttpContext.User.Claims
        //            .Where(x => x.Type == ClaimTypes.Name)
        //            .Select(x => x.Value)
        //            .FirstOrDefault();
        //    return Content($"<p>Hello to Code Maze {userName}</p>");
        //}
    }
}
