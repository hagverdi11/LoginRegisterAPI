using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTOs.Account;
using ServiceLayer.Services.Interfaces;

namespace API_Intro.Controllers
{
    public class AccountController : AppController
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromBody]RegisterDto user)
        {
            return Ok(await _accountService.RegisterAsync(user));
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginDto user)
        {
            return Ok(await _accountService.LoginAsync(user));
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole([FromBody] RoleDto role)
        {
            await _accountService.CreateRoleAsync(role);
            return Ok();
        }
    }
}
