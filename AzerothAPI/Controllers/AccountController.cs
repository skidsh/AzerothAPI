using AzerothAPI.DTO;
using AzerothAPI.DTO.Account;
using AzerothAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace AzerothAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly ILogger<AccountController> _logger;
        private readonly IAccountService _accountService;
        private readonly IBlogService _blogService;
        private readonly IConfiguration _config;

        public AccountController(ILogger<AccountController> logger, IAccountService accountService, IBlogService blogService, IConfiguration config)
        {
            _logger = logger;
            _accountService = accountService;
            _blogService = blogService;
            _config = config;
        }

        [HttpPost("[action]")]
        public async Task<ActionResult<AuthResponse>> Auth([FromBody] SignInRequest request)
        {
            if (request.Username == null || request.EncodedPassword == null) { return BadRequest(); }
            var passBytes = Convert.FromBase64String(request.EncodedPassword);
            var password = Encoding.UTF8.GetString(passBytes);
            var account = _accountService.Auth(request.Username, password);
            if (account != null)
            {
                return Ok(new AuthResponse { 
                    Username = request.Username,
                    Email = account.Email,
                    Token = TokenHelper.GetToken(request.Username, _config),
                    IsAdmin = await _blogService.UserIsAdmin((int)account.Id)
                });
            }
            return BadRequest();
        }

        [HttpGet("[action]")]
        public ActionResult<bool> CheckUser(string username)
        {
            if (username == null) { return BadRequest(); }
            return _accountService.UserOrEmailAvailable(username, null);
        }

        [HttpGet("[action]")]
        public ActionResult<bool> CheckEmail(string email)
        {
            if (email == null) { return BadRequest(); } 
            return Ok(_accountService.UserOrEmailAvailable(null, email));
        }

        [HttpPost("[action]")]
        public async Task<ActionResult<bool>> Create([FromBody] CreateAccountRequest request)
        {
            if (request.Username == null || request.Email == null || request.EncodedPassword == null) { return BadRequest(); }
            var passBytes = Convert.FromBase64String(request.EncodedPassword);
            var password = Encoding.UTF8.GetString(passBytes);
            return Ok(await _accountService.CreateAccount(request.Username.ToUpper(), password, request.Email.ToUpper()));
        }

        [HttpPost("[action]")]
        public async Task<ActionResult<bool>> UpdateUsername(string oldUser, string newUser, string currentPassword)
        {
            if (oldUser == null || newUser == null || currentPassword == null) { return BadRequest(); }
            var passBytes = Convert.FromBase64String(currentPassword);
            var password = Encoding.UTF8.GetString(passBytes);
            return Ok(await _accountService.UpdateUsername(oldUser, newUser, password));
        }

        [HttpPost("[action]")]
        public async Task<ActionResult<bool>> UpdatePassword(string oldUser, string currentPassword, string newPassword)
        {
            if (oldUser == null || newPassword == null || currentPassword == null) { return BadRequest(); }
            var passBytes = Convert.FromBase64String(currentPassword);
            var password = Encoding.UTF8.GetString(passBytes);

            var newPassBytes = Convert.FromBase64String(newPassword);
            var newPass = Encoding.UTF8.GetString(newPassBytes);
            return Ok(await _accountService.UpdatePassword(oldUser, password, newPass));
        }

        [HttpPost("[action]")]
        public async Task<ActionResult<bool>> UpdateEmail(string user, string pass, string newEmail)
        {
            if (user == null || pass == null || newEmail == null) { return BadRequest(); }
            var passBytes = Convert.FromBase64String(pass);
            var password = Encoding.UTF8.GetString(passBytes);
            return Ok(await _accountService.UpdateEmail(user, password, newEmail));
        }
    }
}