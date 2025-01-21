using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace akmsservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController(ILogger<AccountController> logger) : ControllerBase
    {
        private readonly ILogger<AccountController> _logger = logger;

        [ProducesResponseType(typeof(ApiResponse<string>), StatusCodes.Status200OK)]
        [HttpGet]
        [Route("GetUsers")]
        public async Task<IActionResult> GetUsers()
        {
            await Task.Delay(100);
            _logger.LogInformation("GetUsers called");
            var response = new ApiResponse<string>
            {
                Status = ApiResponseStatus.Success,
                StatusCode = StatusCodes.Status200OK,
                ResponseCode = ResponseCodeStatus.Success,
                Txn = ConstantData.Txn,
                ReturnValue = "GetUsers called"
            };
            return Ok(response);
        }
    }
}
