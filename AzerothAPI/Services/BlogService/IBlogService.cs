
using AzerothAPI.DTO.Blog;

namespace AzerothAPI.Services
{
    public interface IBlogService
    {
        Task UpsertPost(int? id, string title, string text, int userId);
        List<PostDTO> GetPosts(int take, int skip);
        Task<bool> SetDispalyName(int userId, string displayName);
        Task<bool> UserIsAdmin(int userId);
        Task DeletePost(int? id);
    }
}