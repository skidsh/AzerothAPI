using AzerothAPI.Data.Context;
using AzerothAPI.Data.Models.Blog;
using AzerothAPI.DTO.Blog;

namespace AzerothAPI.Services
{
    public class BlogService : IBlogService
    {
        private readonly BlogDb _blogContext;
        private readonly IAccountService _accountService;

        public BlogService(BlogDb blogContext, IAccountService accountService)
        {
            this._blogContext = blogContext;
            this._accountService = accountService;
        }

        public List<PostDTO> GetPosts(int take, int skip)
        {
            var posts = _blogContext.Posts
                .OrderByDescending(p => p.PostDate)
                .Take(take)
                .Skip(skip)
                .ToList();           

            return posts.Select(p => new PostDTO
                {
                    Id = p.Id,
                    Title = p.Title,
                    Text = p.Text != null ? System.Text.Encoding.Default.GetString(p.Text) : string.Empty,
                    UserName = p.UserId.HasValue ? GetDisplayName(p.UserId.Value) : string.Empty,
                    UserId = p.UserId.HasValue ? p.UserId.Value : 0,
                    PostDate = p.PostDate,
                    ChangedDate = p.ChangedDate,
                })
                .ToList();
        }

        public async Task<bool> UserIsAdmin(int userId)
        {
            return (await _blogContext.Userpermissions.FindAsync(userId))?.Permission > 0;
        }

        public async Task UpsertPost(int? id, string title, string text, int userId)
        {
            Post? existing = null;
            Post post = new()
            {
                Title = title,
                Text = System.Text.Encoding.Default.GetBytes(text),
                UserId = userId
            };
            if (id > 0)
            {
                existing = await _blogContext.Posts.FindAsync(id);
                if (existing != null)
                {
                    existing.Title = title;
                    existing.Text = System.Text.Encoding.Default.GetBytes(text);
                    existing.UserId = userId;
                }
            }
            _blogContext.Posts.Update(existing ?? post);
            await _blogContext.SaveChangesAsync();
        }

        public async Task DeletePost(int? id)
        {
            var post = await _blogContext.Posts.FindAsync(id);
            if (post != null)
            {
                _blogContext.Remove(post);
                await _blogContext.SaveChangesAsync();
            }
        }

        public async Task<bool> SetDispalyName(int userId, string displayName)
        {
            if (!_blogContext.Displaynames.Any(d => d.DisplayName1 == displayName))
            {
                var displaynames = _blogContext.Displaynames.Where(d => d.UserId == userId);
                if (!displaynames.Any())
                {
                    _blogContext.Displaynames.Add(new Displayname
                    {
                        DisplayName1 = displayName,
                        UserId = userId
                    });
                }
                else
                {
                    var currentDisplayName = displaynames.First();
                    currentDisplayName.DisplayName1 = displayName;
                    _blogContext.Update(currentDisplayName);
                }
                await _blogContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public string GetDisplayName(int userId)
        {
            var query = _blogContext.Displaynames.FirstOrDefault(dn => dn.UserId == userId);
            if (query != null && query != default && query.DisplayName1 != null)
            {
                return query.DisplayName1;
            }
            else
            {
                return _accountService.GetUsername(userId);
            }
        }
    }
}