using JSONPlaceHolderClient;
using JSONPlaceHolderClient.Models;
using System;

namespace JSONPlaceHolderClientSample
{
    public class PostsSample
    {
        public void GetAllPosts()
        {
            Console.WriteLine("GetAllPosts start");

            //JsonPlaceHolder could be injected in order to avoid this manual instantiation
            IJsonPlaceHolder client = new JsonPlaceHolder();
            Post[] posts = client.GetPostsAsync().Result;

            Console.WriteLine($"{posts.Length} posts found");

            foreach (var item in posts)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("GetAllPosts finish");
        }

        public void GetPostsWithFilter()
        {
            Console.WriteLine("GetPostsWithFilter start");

            //JsonPlaceHolder could be injected in order to avoid this manual instantiation
            IJsonPlaceHolder client = new JsonPlaceHolder();

            IFilterBuilder filterBuilder = new FilterBuilder<Post>();
            filterBuilder.AddParameter("userId", "5");
            filterBuilder.AddParameter("id", "41");

            Post[] posts = client.GetPostsAsync(filterBuilder.Build()).Result;

            Console.WriteLine($"{posts.Length} posts found");

            foreach (var item in posts)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("GetPostsWithFilter finish");
        }

        public void GetPost()
        {
            Console.WriteLine("GetPost start");

            //JsonPlaceHolder could be injected in order to avoid this manual instantiation
            IJsonPlaceHolder client = new JsonPlaceHolder();

            for (int i = 10; i < 30; i++)
            {
                Post post = client.GetPostAsync(i).Result;
                Console.WriteLine(post);
            }            

            Console.WriteLine("GetPost finish");
        }

        public void CreatePost()
        {
            Console.WriteLine("CreatePost start");

            Post newPost = new Post
            {
                UserId = 1,
                Body = "New Post Body",
                Title = "New Post Title"
            };

            //JsonPlaceHolder could be injected in order to avoid this manual instantiation
            IJsonPlaceHolder client = new JsonPlaceHolder();
            Post post = client.CreatePostAsync(newPost).Result;
            Console.WriteLine(post);

            Console.WriteLine("CreatePost finish");
        }

        public void UpdatePost()
        {
            Console.WriteLine("UpdatePost start");

            Post newPost = new Post
            {
                Id = 5,
                UserId = 1,
                Body = "New Post Body",
                Title = "New Post Title"
            };

            //JsonPlaceHolder could be injected in order to avoid this manual instantiation
            IJsonPlaceHolder client = new JsonPlaceHolder();
            Post post = client.UpdatePostAsync(newPost).Result;
            Console.WriteLine(post);

            Console.WriteLine("UpdatePost finish");
        }

        public void DeletePost()
        {
            Console.WriteLine("DeletePost start");

            IJsonPlaceHolder client = new JsonPlaceHolder();
            Post post = client.DeletePostAsync(1).Result;
            Console.WriteLine(post);

            Console.WriteLine("DeletePost finish");
        }
    }
}