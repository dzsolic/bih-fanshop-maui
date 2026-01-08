using System;
using System.Collections.Generic;
using System.Text;
using BHFanShop.Models;
using System.Linq;
using System.Runtime.Loader;
namespace BHFanShop.Services
{
    public static class LoginService
    {
        private static DBService dbService = new DBService();
        public static User CurrentUser { get; set; }
        public static async Task<bool> Register(string username, string password, string fullName, string email, string phone, string address)
        {
            var existing = await dbService.GetUserAsync(username);
            if (existing != null) return false;
            var newUser = new User
            {
                Username = username,
                Password = password,
                FullName = fullName,
                Email = email,
                Phone = phone,
                Address = address
            };
            await dbService.SaveUserAsync(newUser);
            return true;
        }
        public static async Task<bool> Login(string username, string password)
        {

            var user = await dbService.GetUserAsync(username);

            if (user != null && user.Password == password)
            {
                CurrentUser = user;
                return true;
            }
            return false;
        }
        public static async void AddTicketCurrentUser()
        {
            if (CurrentUser != null)
            {
                CurrentUser.TicketCounter += 1;
                StatusCheckCurrentUser();
                await dbService.SaveUserAsync(CurrentUser);
            }
        }
        public static async void AddJerseyCurrentUser()
        {
            if (CurrentUser != null)
            {
                CurrentUser.JerseyCounter += 1;
                StatusCheckCurrentUser();
                await dbService.SaveUserAsync(CurrentUser);
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
