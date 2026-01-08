using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using BHFanShop.Models;

namespace BHFanShop.Services
{
    public class DBService
    {
        private SQLiteAsyncConnection _database;

        async Task Init()
        {
            if (_database is not null) return;

           
            var dbPath = Path.Combine(FileSystem.AppDataDirectory, "BHFanShop.db3");

            _database = new SQLiteAsyncConnection(dbPath);
            await _database.CreateTableAsync<User>();
        }

        public async Task<List<User>> GetUsersAsync()
        {
            await Init();
            return await _database.Table<User>().ToListAsync();
        }

        public async Task<User> GetUserAsync(string username)
        {
            await Init();
            return await _database.Table<User>().Where(i => i.Username == username).FirstOrDefaultAsync();
        }

        public async Task<int> SaveUserAsync(User user)
        {
            await Init();
            var existingUser = await GetUserAsync(user.Username);
            if (existingUser != null)
                return await _database.UpdateAsync(user);
            else
                return await _database.InsertAsync(user);
        }
    }
}
