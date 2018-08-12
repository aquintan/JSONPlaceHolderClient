using JSONPlaceHolderClient;
using JSONPlaceHolderClient.Models;
using System;

namespace JSONPlaceHolderClientSample
{
    public class UsersSample
    {
        public void GetAllUsers()
        {
            Console.WriteLine("GetAllUsers start");

            IJsonPlaceHolder client = new JsonPlaceHolder();
            User[] users = client.GetUserAsync().Result;

            Console.WriteLine($"{users.Length} posts found");

            foreach (var item in users)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("GetAllUsers finish");
        }

        public void GetUser()
        {
            Console.WriteLine("GetUser start");

            IJsonPlaceHolder client = new JsonPlaceHolder();

            for (int i = 1; i < 5; i++)
            {
                User user = client.GetUserAsync(i).Result;
                Console.WriteLine(user);
            }

            Console.WriteLine("GetUser finish");
        }

        public void CreateUser()
        {
            Console.WriteLine("CreateUser start");

            User user = new User
            {
                Name = "Alvaro",
                UserName = "aquintana",
                Email = "aquintan@gmail.com",
                Phone = "123",
                Website = "www.site.com",
                Address = new Address {  City = "Cartagena", Email = "email@gmail.com", Street = "Street", Suite = "Suite 1", Geolocation = new Geolocation { Latitude = -37.3159, Longitude = 81.1496 } }
            };

            IJsonPlaceHolder client = new JsonPlaceHolder();
            User post = client.CreateUserAsync(user).Result;
            Console.WriteLine(post);

            Console.WriteLine("CreateUser finish");
        }

        public void DeleteUser()
        {
            Console.WriteLine("DeleteUser start");

            IJsonPlaceHolder client = new JsonPlaceHolder();
            Post post = client.DeletePostAsync(1).Result;
            Console.WriteLine(post);

            Console.WriteLine("DeleteUser finish");
        }
    }
}