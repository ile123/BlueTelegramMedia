using Domain.Entities;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Backend.Services
{
    public class ReviewerService
    {
        private readonly HttpClient _httpClient;
        private readonly string BaseApiUrl = "https://localhost:44340/api/Reviewer";
        public ReviewerService(HttpClient httpClient) => _httpClient = httpClient;
        public async Task<List<Reviewer>> GetReviewers()
        {
            return await _httpClient.GetFromJsonAsync<List<Reviewer>>(BaseApiUrl);
        }
        public async Task AddReviewerAsync(Reviewer reviewer)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, BaseApiUrl);
            request.Content = new StringContent(JsonSerializer.Serialize(reviewer), Encoding.UTF8, "application/json");
            await _httpClient.SendAsync(request);
        }
        public async Task<Reviewer> GetReviewerAsync(int reviewerId)
        {
            return await _httpClient.GetFromJsonAsync<Reviewer>($"{BaseApiUrl}/{reviewerId}");
        }

        public async Task<Reviewer> GetReviewerByUsernameAsync(string reviewerUsername)
        {
            return await _httpClient.GetFromJsonAsync<Reviewer>($"{BaseApiUrl}/{reviewerUsername}");
        }

        public async Task UpdateReviewerAsync(Reviewer reviewer)
        {
            var request = new HttpRequestMessage(HttpMethod.Put, BaseApiUrl);
            request.Content = new StringContent(JsonSerializer.Serialize(reviewer), Encoding.UTF8, "application/json");
            await _httpClient.SendAsync(request);
        }
        public async Task DeleteReviewerAsync(int reviewerId)
        {
            var httpRequest = new HttpRequestMessage(HttpMethod.Delete, $"{BaseApiUrl}/{reviewerId}");
            await _httpClient.SendAsync(httpRequest);
        }
    }
}
