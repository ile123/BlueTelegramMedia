using Domain.Entities;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Backend.Services
{
    public class MovieService
    {
        private readonly HttpClient _httpClient;
        private readonly string BaseApiUrl = "https://localhost:44340/api/Movie";
        public MovieService(HttpClient httpClient) => _httpClient = httpClient;
        public async Task<List<Movie>> GetMovies()
        {
            return await _httpClient.GetFromJsonAsync<List<Movie>>(BaseApiUrl);
        }
        public async Task AddMovieAsync(Movie movie)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, BaseApiUrl);
            request.Content = new StringContent(JsonSerializer.Serialize(movie), Encoding.UTF8, "application/json");
            await _httpClient.SendAsync(request);
        }
        public async Task<Movie> GetMovieAsync(int movieId)
        {
            return await _httpClient.GetFromJsonAsync<Movie>($"{BaseApiUrl}/{movieId}");
        }
        public async Task<Movie> GetMovieByNameAsync(string movieName)
        {
            return await _httpClient.GetFromJsonAsync<Movie>($"{BaseApiUrl}/{movieName}");
        }
        public async Task UpdateMovieAsync(Movie movie)
        {
            var request = new HttpRequestMessage(HttpMethod.Put, BaseApiUrl);
            request.Content = new StringContent(JsonSerializer.Serialize(movie), Encoding.UTF8, "application/json");
            await _httpClient.SendAsync(request);
        }
        public async Task DeleteMovieAsync(int movieId)
        {
            var httpRequest = new HttpRequestMessage(HttpMethod.Delete, $"{BaseApiUrl}/{movieId}");
            await _httpClient.SendAsync(httpRequest);
        }
    }
}
