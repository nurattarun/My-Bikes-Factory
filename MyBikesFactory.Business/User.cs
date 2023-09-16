using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikesFactory.Business
{
    public class User
    {
        private string _username;
        private string _password;

        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }

        public User(string initialUsername, string initialPassword)
        {
            _username = initialUsername;
            _password = initialPassword;
        }
    }
}
