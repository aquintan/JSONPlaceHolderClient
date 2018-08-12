using JSONPlaceHolderClient;
using JSONPlaceHolderClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONPlaceHolderClientSample
{
    public class Program
    {
        static void Main(string[] args)
        {
            //JsonPlaceHolder could be injected in order to avoid this manual instantiation
            IJsonPlaceHolder client = new JsonPlaceHolder();

            Post[] posts = client.GetPostsAsync().Result;

            Console.WriteLine($"{posts.Length} posts found");

            foreach (var item in posts)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Sample Finished");
            Console.ReadKey();
        }
    }
}
