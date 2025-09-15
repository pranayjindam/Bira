using Bira.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Bira.Services
{
    internal class UserService
    {
        private readonly HttpClient _httpClient;

        //public UserService()
        //{
        //    _httpClient = new HttpClient();
        //}

        //public async Task<List<UserModel>> GetUsersAsync()
        //{
        //    string apiUrl = "https://example.com/api/users"; // Replace with your real API endpoint

        //    var response = await _httpClient.GetAsync(apiUrl);

        //    if (response.IsSuccessStatusCode)
        //    {
        //        var json = await response.Content.ReadAsStringAsync();
        //        var users = JsonSerializer.Deserialize<List<UserModel>>(json,
        //            new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

        //        return users;
        //    }

        //    // Return empty list if API fails
        //    return new List<UserModel>();
        //}


        public async Task<List<UserModel>> GetUsersAsync()
        {
            await Task.Delay(150); // Simulate async network call

            return new List<UserModel>
            {
                new UserModel
                {
                    UserId = 101,
                    FirstName = "Jane",
                    LastName = "Smith",
                    Email = "jane.smith@example.com",
                    Role = "Team Lead"
                },
                new UserModel
                {
                    UserId = 102,
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "john.doe@example.com",
                    Role = "Developer"
                },
                new UserModel
                {
                    UserId = 103,
                    FirstName = "Peter",
                    LastName = "Jones",
                    Email = "peter.jones@example.com",
                    Role = "QA Engineer"
                },
                new UserModel
                {
                    UserId = 104,
                    FirstName = "Mary",
                    LastName = "Williams",
                    Email = "mary.w@example.com",
                    Role = "UI/UX Designer"
                }
            };
        }
    }
}

