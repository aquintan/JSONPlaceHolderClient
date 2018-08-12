using JSONPlaceHolderClient.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace JSONPlaceHolderClient
{
    public class JsonPlaceHolder : APIResource, IJsonPlaceHolder
    {
        #region Constructor

        public JsonPlaceHolder(HttpMessageHandler handler = null) : base(handler)
        {
        }

        #endregion Constructor

        #region IJsonPlaceHolder Implementation

        #region Posts

        public async Task<Post> GetPostAsync(int id)
        {
            return await GetDataAsync<Post>($"posts/{id}");
        }

        public async Task<Post[]> GetPostsAsync()
        {
            return await GetDataAsync<Post[]>("posts");
        }

        public async Task<Post> CreatePostAsync(Post post)
        {
            return await PostDataAsync<Post>("posts", post);
        }

        public async Task<Post> UpdatePostAsync(Post post)
        {
            return await PutDataAsync<Post>($"posts/{post.Id}", post);
        }

        public async Task<Post> DeletePostAsync(int id)
        {
            return await DeleteDataAsync<Post>($"posts/{id}");
        }

        public async Task<Comment[]> GetPostCommentsAsync(int id)
        {
            return await GetDataAsync<Comment[]>($"posts/{id}/comments");
        }

        public async Task<User[]> GetPostUsersAsync(int id)
        {
            return await GetDataAsync<User[]>($"posts/{id}/users");
        }

        #endregion Posts

        #region Comments

        public async Task<Comment[]> GetCommentsAsync()
        {
            return await GetDataAsync<Comment[]>("comments");
        }

        public async Task<Comment> GetCommentAsync(int id)
        {
            return await GetDataAsync<Comment>($"comments/{id}");
        }

        public async Task<Comment> CreateCommentAsync(Comment comment)
        {
            return await PostDataAsync<Comment>("comments", comment);
        }

        public async Task<Comment> UpdateCommentAsync(Comment comment)
        {
            return await PutDataAsync<Comment>("comments", comment);
        }

        public async Task<Comment> DeleteCommentAsync(int id)
        {
            return await DeleteDataAsync<Comment>($"comments/{id}");
        }

        #endregion Comments

        #region Albums

        public async Task<Album[]> GetAlbumsAsync()
        {
            return await GetDataAsync<Album[]>("albums");
        }

        public async Task<Album> GetAlbumAsync(int id)
        {
            return await GetDataAsync<Album>($"albums/{id}");
        }

        public async Task<Album> CreateAlbumAsync(Comment comment)
        {
            return await PostDataAsync<Album>("albums", comment);
        }

        public async Task<Album> UpdateAlbumAsync(Comment comment)
        {
            return await PutDataAsync<Album>("albums", comment);
        }

        public async Task<Album> DeleteAlbumAsync(int id)
        {
            return await DeleteDataAsync<Album>($"albums/{id}");
        }
        #endregion

        #region Photos
        public async Task<Photo[]> GetPhotosAsync()
        {
            return await GetDataAsync<Photo[]>("photos");
        }

        public async Task<Photo> GetPhotoAsync(int id)
        {
            return await GetDataAsync<Photo>($"photos/{id}");
        }

        public async Task<Photo> CreatePhotoAsync(Photo photo)
        {
            return await PostDataAsync<Photo>("photos", photo);
        }

        public async Task<Photo> UpdatePhotoAsync(Photo photo)
        {
            return await PutDataAsync<Photo>("photos", photo);
        }

        public async Task<Photo> DeletePhotoAsync(int id)
        {
            return await DeleteDataAsync<Photo>($"photos/{id}");
        }
        #endregion

        #region Todos
        public async Task<Todo[]> GetTodosAsync()
        {
            return await GetDataAsync<Todo[]>("todos");
        }

        public async Task<Todo> GetTodoAsync(int id)
        {
            return await GetDataAsync<Todo>($"todos/{id}");
        }

        public async Task<Todo> CreateTodoAsync(Todo todo)
        {
            return await PostDataAsync<Todo>("todos", todo);
        }

        public async Task<Todo> UpdateTodoAsync(Todo todo)
        {
            return await PutDataAsync<Todo>("todos", todo);
        }

        public async Task<Todo> DeleteTodoAsync(int id)
        {
            return await DeleteDataAsync<Todo>($"todos/{id}");
        }
        #endregion

        #region Users
        public async Task<User[]> GetUserAsync()
        {
            return await GetDataAsync<User[]>("users");
        }

        public async Task<User> GetUserAsync(int id)
        {
            return await GetDataAsync<User>($"users/{id}");
        }

        public async Task<User> CreateUserAsync(User user)
        {
            return await PostDataAsync<User>("users", user);
        }

        public async Task<User> UpdateUserAsync(User user)
        {
            return await PutDataAsync<User>("users", user);
        }

        public async Task<User> DeleteUserAsync(int id)
        {
            return await DeleteDataAsync<User>($"albums/{id}");
        }        
        #endregion

        #endregion IJsonPlaceHolder Implementation
    }
}