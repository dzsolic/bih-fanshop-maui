using System;
using System.Collections.Generic;
using System.Text;
using BHFanShop.Models;
using System.Linq;
namespace BHFanShop.Services
{
    public static class LoginService
    {
        private static List<User> users = new List<User>();
        public static User CurrentUser { get; set; }
        public static bool Register(string username, string password)
        {
            foreach (var u in users)
            {
                if (u.Username == username)
                {
                    return false;
                }
            }
            users.Add(new User { Username = username, Password = password });
            return true;
        }
        public static bool Login(string username, string password)
        {

            foreach (var u in users)
            {

                if (u.Username == username && u.Password == password)
                {
                    CurrentUser = u;
                    return true;
                }
            }
            return false;
        }
    }
}
