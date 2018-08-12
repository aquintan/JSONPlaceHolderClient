using System;

namespace JSONPlaceHolderClientSample
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("SAMPLE PROGRAM START");
            string command = (args.Length == 0) ? String.Empty : args[0];

            switch (command)
            {
                case "posts":
                    PostsSample sample = new PostsSample();
                    sample.GetAllPosts();
                    sample.GetPost();
                    sample.CreatePost();
                    sample.UpdatePost();
                    sample.DeletePost();
                    break;
                case "users":
                    UsersSample usersSample = new UsersSample();
                    usersSample.GetAllUsers();
                    usersSample.GetUser();
                    usersSample.CreateUser();
                    break;
                default:
                    Console.WriteLine("Unsupported argument");
                    break;
            }

            Console.Write("SAMPLE PROGRAM ENDED");
            Console.ReadKey();
        }
    }
}