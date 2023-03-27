using AzerothAPI.Data.Models.Char;

namespace AzerothAPI.DTO
{
    public partial class CharSearchResult
    {
        public List<CharResult>? Characters { get; set; } = new List<CharResult>();
        public int Count { get; set; } = 0;
    }
}
