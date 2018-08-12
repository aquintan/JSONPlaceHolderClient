using JSONPlaceHolderClient.Models;
using System.Threading.Tasks;

namespace JSONPlaceHolderClient
{
    /// <summary>
    /// Defines the methods that wraps the features in "https://jsonplaceholder.typicode.com/".
    /// </summary>
    public interface IJsonPlaceHolder
    {
        #region Posts Methods

        Task<Post[]> GetPostsAsync();

        Task<Post[]> GetPostsAsync(IFilter filter);

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

        #endregion Comments Methods

        #region Albums Methods

        Task<Album[]> GetAlbumsAsync();

        Task<Album> GetAlbumAsync(int id);

        Task<Album> CreateAlbumAsync(Comment comment);

        Task<Album> UpdateAlbumAsync(Comment comment);

        Task<Album> DeleteAlbumAsync(int id);

        #endregion Albums Methods

        #region Photos Methods

        Task<Photo[]> GetPhotosAsync();

        Task<Photo> GetPhotoAsync(int id);

        Task<Photo> CreatePhotoAsync(Photo photo);

        Task<Photo> UpdatePhotoAsync(Photo photo);

        Task<Photo> DeletePhotoAsync(int id);

        #endregion Photos Methods

        #region Todos Methods

        Task<Todo[]> GetTodosAsync();

        Task<Todo> GetTodoAsync(int id);

        Task<Todo> CreateTodoAsync(Todo todo);

        Task<Todo> UpdateTodoAsync(Todo todo);

        Task<Todo> DeleteTodoAsync(int id);

        #endregion Photos Methods

        #region Users Methods

        Task<User[]> GetUserAsync();

        Task<User> GetUserAsync(int id);

        Task<User> CreateUserAsync(User comment);

        Task<User> UpdateUserAsync(User comment);

        Task<User> DeleteUserAsync(int id);

        #endregion Users Methods
    }
}