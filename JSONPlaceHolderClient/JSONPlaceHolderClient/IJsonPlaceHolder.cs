using JSONPlaceHolderClient.Models;
using System.Threading.Tasks;

namespace JSONPlaceHolderClient
{
    public interface IJsonPlaceHolder
    {
        #region Posts Methods

        Task<Post[]> GetPostsAsync();

        Task<Post> GetPostAsync(int id);

        Task<Post> CreatePostAsync(Post post);

        Task<Post> UpdatePostAsync(Post post);

        Task<Post> DeletePostAsync(int id);

        Task<Comment[]> GetPostCommentsAsync(int id);

        Task<User[]> GetPostUsersAsync(int id);

        #endregion Posts Methods

        #region Comments Methods

        Task<Comment[]> GetCommentsAsync();

        Task<Comment> GetCommentAsync(int id);

        Task<Comment> CreateCommentAsync(Comment comment);

        Task<Comment> UpdateCommentAsync(Comment comment);

        Task<Comment> DeleteCommentAsync(int id);

        #endregion Comment Methods

        #region Albums Methods

        Task<Album[]> GetAlbumsAsync();

        Task<Album> GetAlbumAsync(int id);

        Task<Album> CreateAlbumAsync(Comment comment);

        Task<Album> UpdateAlbumAsync(Comment comment);

        Task<Album> DeleteAlbumAsync(int id);

        #endregion Albums Methods
    }
}