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
        #endregion

        #region Todos
        #endregion

        #region Users
        #endregion

        #endregion IJsonPlaceHolder Implementation
    }
}