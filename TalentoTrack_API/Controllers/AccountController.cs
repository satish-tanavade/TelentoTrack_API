using Microsoft.AspNetCore.Mvc;
using TalentoTrack.Common.DTOs.Account;
using TalentoTrack.Common.Services;

namespace TalentoTrack_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost(Name ="Login")]
        public async Task <LoginResponse> Login([FromBody] TalentoTrack.Common.DTOs.Account.LoginRequest request)
        {
            var response = await _accountService.VerifyLoginDetails(request);
          
            return response;
        }
    }
}
