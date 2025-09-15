using Bira.Models;
using Bira.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IdentityModel.Tokens.Jwt;
using Bira.Dtos;

namespace Bira.Services
{
    internal class AuthService
    {
        private readonly HttpClient _httpClient;

        public AuthService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<UserModel> GetLogin(LoginDto loginDto)
        {
            string apiUrl = Resources.api; // Base API URL

            var content = new StringContent(JsonConvert.SerializeObject(loginDto), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync($"{apiUrl}/Auth/login", content);

            if (!response.IsSuccessStatusCode)
                return null;

            // Read API response JSON
            string responseJson = await response.Content.ReadAsStringAsync();

            // Extract token from response
            var tokenObj = JsonConvert.DeserializeObject<Dictionary<string, string>>(responseJson);
            if (!tokenObj.TryGetValue("token", out string jwtTokenString))
                return null;

            // Decode JWT claims
            var handler = new JwtSecurityTokenHandler();
            var jwtToken = handler.ReadJwtToken(jwtTokenString);

            var claimsDict = jwtToken.Claims.ToDictionary(c => c.Type, c => (object)c.Value);

            // Optionally print JSON
            string claimsJson = JsonConvert.SerializeObject(claimsDict, Formatting.Indented);
            Console.WriteLine(claimsJson);

            // Map claims to UserModel
            var user = new UserModel
            {   
                UserId = claimsDict.TryGetValue("UserId", out var id) ? int.Parse(id.ToString()) : 0,
                UserName = claimsDict.TryGetValue("Name", out var n) ? n.ToString() : null,
                Email = claimsDict.TryGetValue("Email", out var e) ? e.ToString() : null,
                Role = claimsDict.TryGetValue("Role", out var r) ? r.ToString() : null
            };

            return user;
        }

        //public async Task<UserModel> GetRegister()
        //{
        //    string apiUrl = Resources.api; // Your API endpoint

        //    var response = await _httpClient.GetAsync($"{apiUrl}/Auth/register");

        //    if (!response.IsSuccessStatusCode)
        //        return null;




            //// string json = JsonConvert.SerializeObject(claimsDict, Formatting.Indented);

            //Console.WriteLine(json);

            //var user = JsonConvert.DeserializeObject<UserModel>(json);

            //return user;
        }
    }
    
