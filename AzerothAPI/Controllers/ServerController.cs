using AzerothAPI.DTO.Account;
using AzerothAPI.DTO.Realm;
using AzerothAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace AzerothAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServerController : ControllerBase
    {
        private readonly ILogger<ServerController> _logger;
        private readonly IServerService _serverService;
        private readonly IConfiguration _config;

        public ServerController(ILogger<ServerController> logger, IServerService serverService, IConfiguration config)
        {
            _logger = logger;
            _serverService = serverService;
            _config = config;
        }

        [HttpGet("[action]")]
        public ActionResult<RealmDTO> GetRealm()
        {
            return Ok(_serverService.GetRealm());
        }
    }
}