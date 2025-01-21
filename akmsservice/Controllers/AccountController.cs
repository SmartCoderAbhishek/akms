using Microsoft.AspNetCore.Mvc;

namespace akmsservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController(ILogger<AccountController> logger) : ControllerBase
    {
        private readonly ILogger<AccountController> _logger = logger;

        [HttpGet]
        [Route("GetUsers")]
        public async Task<IActionResult> GetUsers()
        {
            await Task.Delay(100);
            _logger.LogInformation("GetUsers called");
            return Ok("GetUsers called");
        }
    }
}
