using AzerothAPI.DTO;
using AzerothAPI.DTO.Blog;
using AzerothAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace AzerothAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlogController : ControllerBase
    {
        private readonly ILogger<BlogController> _logger;
        private readonly IBlogService _blogService;
        private readonly IAccountService _accountService;
        private readonly IConfiguration _config;

        public BlogController(ILogger<BlogController> logger, IBlogService blogService, IAccountService accountService, IConfiguration config)
        {
            _logger = logger;
            _blogService = blogService;
            _accountService = accountService;
            _config = config;
        }

        [HttpGet("[action]")]
        public ActionResult<List<PostDTO>> GetPosts(int take, int skip)
        {
            return Ok(_blogService.GetPosts(take, skip));
        }

        [HttpPost("[action]")]
        public async Task<ActionResult<PostDTO>> DeletePost(int? id, string jwt)
        {
            if (id <= 0) return BadRequest();

            if (await _blogService.UserIsAdmin(TokenHelper.GetUserIdFromJWT(jwt, _config, _accountService)))
            {
                await _blogService.DeletePost(id);
            }
            else
            {
                return Unauthorized();
            }
            return Ok();
        }

        [HttpPost("[action]")]
        public async Task<ActionResult> UpsertPost([FromBody] CreatePostRequest request)
        {
            if (request.Title == null || request.Text == null) { return BadRequest(); }
            int userId = TokenHelper.GetUserIdFromJWT(request.JWT, _config, _accountService);
            if (await _blogService.UserIsAdmin(userId))
            {
                await _blogService.UpsertPost(request.Id, request.Title, request.Text, userId);
            }
            else
            {
                return Unauthorized();
            }
            return Ok();
        }

        [HttpPost("[action]")]
        public async Task<ActionResult> SetDisplayName(int userId, string displayName)
        {
            if (displayName == null || userId <= 0) { return BadRequest(); }
            var result = await _blogService.SetDispalyName(userId, displayName);
            return result ? Ok() : BadRequest();
        }
    }
}