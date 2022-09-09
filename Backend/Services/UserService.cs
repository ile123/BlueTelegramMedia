﻿using Domain.Entities;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Backend.Services
{
    public class UserService
    {
        private readonly HttpClient _httpClient;
        private readonly string BaseApiUrl = "https://localhost:44340/api/User";
        public UserService(HttpClient httpClient) => _httpClient = httpClient;
        public async Task<List<User>> GetUsers()
        {
            return await _httpClient.GetFromJsonAsync<List<User>>(BaseApiUrl);
        }
        public async Task AddUserAsync(User user)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, BaseApiUrl);
            request.Content = new StringContent(JsonSerializer.Serialize(user), Encoding.UTF8, "application/json");
            await _httpClient.SendAsync(request);
        }
        public async Task<User> GetUserAsync(int userId)
        {
            return await _httpClient.GetFromJsonAsync<User>($"{BaseApiUrl}/{userId}");
        }

        public async Task<User> GetUserByUserNameAsync(string username)
        {
            return await _httpClient.GetFromJsonAsync<User>($"{BaseApiUrl}/{username}");
        }

        public async Task UpdateUserAsync(User user)
        {
            var request = new HttpRequestMessage(HttpMethod.Put, BaseApiUrl);
            request.Content = new StringContent(JsonSerializer.Serialize(user), Encoding.UTF8, "application/json");
            await _httpClient.SendAsync(request);
        }
        public async Task DeleteUserAsync(int userId)
        {
            var httpRequest = new HttpRequestMessage(HttpMethod.Delete, $"{BaseApiUrl}/{userId}");
            await _httpClient.SendAsync(httpRequest);
        }
    }
}
