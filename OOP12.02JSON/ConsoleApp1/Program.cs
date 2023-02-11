using ConsoleApp1.JSON;
using System.Text.Json;


namespace ConsoleApp1// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User(1, "Test", DateTime.UtcNow, UserStatus.Admin);
            //{
            //    user.Id = 1;
            //    user.Name = "Test";
            //    user.LastUpdate = DateTime.UtcNow;
            //    user.Status = UserStatus.Admin;
            //}
            Console.WriteLine("ToString");
            Console.WriteLine(user.ToString());


            string json = JsonSerializer.Serialize(user);
            Console.WriteLine("JsonSerializer.Serialize");
            Console.WriteLine(json);
            
            User newUser = JsonSerializer.Deserialize<User>(json);
            Console.WriteLine("JsonSerializer.Deserialize");
            Console.WriteLine(newUser);

            var serializeOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            };
            string json1 = JsonSerializer.Serialize(user, serializeOptions);
            Console.WriteLine("JsonSerializerOptions, JsonSerializer.Serialize");
            Console.WriteLine(json1);

            User newUser1 = JsonSerializer.Deserialize<User>(json, serializeOptions);
            Console.WriteLine("JsonSerializerOptions, JsonSerializer.Deserialize");
            Console.WriteLine(newUser1);
        }

       
    }
}