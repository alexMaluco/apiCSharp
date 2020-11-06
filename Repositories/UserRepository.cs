using System.Collections.Generic;
using System.Linq;
using challengeSeniorUp.Models;

namespace challengeSeniorUp.Repositories
{
    public static class UserRepository
    {
        public static User Get( string username, string password)
        {
            var users = new List<User>();
            users.Add(new User { Id = 1, Username = "alex", Password = "programador"});
            users.Add(new User { Id = 2, Username = "camila", Password = "mestranda"});
            return users.where( x => x.Username.ToLower() == username.ToLower() && x.Password == password ).FirstOrDefault();
        }
    }
}