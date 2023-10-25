using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public static class Userservice
    {
        public static string Surname { get; set; }
        public static string Name { get; set; }
        public static string Password { get; set; }
        public static List<User>users = new List<User>();
        public static void Register(string name,string surname,string password) 
        {
            Console.WriteLine($"{name}:{surname}:{password}");
        }
        public static bool Login(string username,string password)
        {
            foreach(User user in users)
            {
                string wantedusers = users.Find(username => username.ToString())==username;
                if (user.
                {
                    
                }


            }
        }
    }
}
