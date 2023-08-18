using DocumentGenerationSystemCore.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DocumentGenerationSystemCore.Controllers;

[ApiController]
[Route("[controller]")]
public class LoginController : ControllerBase
{
   

    private readonly ILogger<LoginController> _logger;

    public LoginController(ILogger<LoginController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> Login(LoginDataModel loginData) 
    {
        /// <summary>
        /// Implementation of Async Model required here 
        /// </summary>
        /// <returns></returns>
         var tokeninformation = new TokenInformation();
         return Ok(tokeninformation);
    }
}

