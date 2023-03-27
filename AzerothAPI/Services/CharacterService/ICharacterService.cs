using AzerothAPI.DTO;

namespace AzerothAPI.Services
{
    public interface ICharacterService
    {
        CharSearchResult GetCharsForAccount(string accountName);
        CharSearchResult SearchCharacterPaged(string nameSearch, int skip, int take);
        Task<CharacterDetail> GetCharByName(string characterName);
    }
}