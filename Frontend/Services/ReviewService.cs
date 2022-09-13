using System.Net.Http;

using Domain.Entities;
using API.Controllers;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text;

namespace Frontend.Services
{
    public class ReviewService
    {
        private readonly HttpClient _httpClient;
        private readonly string BaseApiUrl = "https://localhost:44340/api/Review";
        public ReviewService(HttpClient httpClient) => _httpClient = httpClient;
        public async Task<List<Review>> GetReviews()
        {
            return await _httpClient.GetFromJsonAsync<List<Review>>(BaseApiUrl);
        }
        public async Task<List<Review>> GetReviewsByMovie(int MovieId)
        {
            return await _httpClient.GetFromJsonAsync<List<Review>>($"{BaseApiUrl}/movie/{MovieId}");
        }
        public async Task<List<Review>> GetReviewsByReviewer(int ReviewerId)
        {
            return await _httpClient.GetFromJsonAsync<List<Review>>($"{BaseApiUrl}/reviewer/{ReviewerId}");
        }
        public async Task AddReviewAsync(Review review)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, BaseApiUrl);
            request.Content = new StringContent(JsonSerializer.Serialize(review), Encoding.UTF8, "application/json");
            await _httpClient.SendAsync(request);
        }
        public async Task<Review> GetReviewAsync(int reviewId)
        {
            return await _httpClient.GetFromJsonAsync<Review>($"{BaseApiUrl}/{reviewId}");
        }

        public async Task UpdateReviewAsync(Review review)
        {
            var request = new HttpRequestMessage(HttpMethod.Put, BaseApiUrl);
            request.Content = new StringContent(JsonSerializer.Serialize(review), Encoding.UTF8, "application/json");
            await _httpClient.SendAsync(request);
        }
        public async Task DeleteReviewAsync(int reviewId)
        {
            var httpRequest = new HttpRequestMessage(HttpMethod.Delete, $"{BaseApiUrl}/{reviewId}");
            await _httpClient.SendAsync(httpRequest);
        }
    }
}
