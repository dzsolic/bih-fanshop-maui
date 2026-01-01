using System;
using System.Collections.Generic;
using System.Text;
using BHFanShop.Models;
using System.Linq;
namespace BHFanShop.Services
{
    public static class LoginService
    {
        private static List<User> users = new List<User>()
        {
            new User{ Username = "a", Password="a", TicketCounter = 0, JerseyCounter = 0,Status = "Navijač"}
        };
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
            users.Add(new User { Username = username, Password = password, TicketCounter = 0, JerseyCounter = 0, Status = "Navijač" });
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
        public static void AddTicketCurrentUser()
        {
            if(CurrentUser != null)
            {
                CurrentUser.TicketCounter += 1;
                StatusCheckCurrentUser();
            }
        }
        public static void AddJerseyCurrentUser()
        {
            if(CurrentUser != null)
            {
                CurrentUser.JerseyCounter += 1;
                StatusCheckCurrentUser();
            }
        }
        private static void StatusCheckCurrentUser() { 
            if(CurrentUser != null)
            {
                int total = CurrentUser.TicketCounter + CurrentUser.JerseyCounter;
                if(total >= 10)
                {
                    CurrentUser.Status = "VIP navijač";
                }
                else if(total >= 5)
                {
                    CurrentUser.Status = "BH FANATIKOS";
                }
                else
                {
                    CurrentUser.Status = "Navijač";
                }
            }
        }


    }
}
