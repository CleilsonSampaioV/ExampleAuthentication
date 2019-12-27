using System;
using System.Collections.Generic;
using System.Linq;
using ExampleAutentication.Models;

namespace ExampleAutentication.Repository
{
    public class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>
            {
                new User() {Username = "batman", Password = "senha123", Role = "manager"},
                new User() {Username = "superman", Password = "senha@123", Role = "employee"}
            };


            return users.FirstOrDefault(x => string.Equals(x.Username, username, StringComparison.CurrentCultureIgnoreCase) && x.Password == password);
        }
    }
}