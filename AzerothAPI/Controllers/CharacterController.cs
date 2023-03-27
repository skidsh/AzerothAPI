using AzerothAPI.DTO;
using AzerothAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace AzerothAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ILogger<AccountController> _logger;
        private readonly ICharacterService _charService;

        public CharacterController(ILogger<AccountController> logger, ICharacterService charService)
        {
            _logger = logger;
            _charService = charService;
        }

        [HttpGet("Search")]
        public CharSearchResult SearchCharactersPaged(string name, int skip, int take)
        {
            return _charService.SearchCharacterPaged(name, skip, take);
        }

        [HttpGet("SearchByAccount")]
        public CharSearchResult SearchByAccount(string accountName)
        {
            return _charService.GetCharsForAccount(accountName);
        }

        [HttpGet("CharacterByName")]
        public async Task<CharacterDetail> GetCharByName(string characterName)
        {
            return await _charService.GetCharByName(characterName);
        }
    }
}