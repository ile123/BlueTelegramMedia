using Domain.Entities;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Frontend.Services
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
        public async Task<Movie> GetMovieAsync(int movieId)
        {
            return await _httpClient.GetFromJsonAsync<Movie>($"{BaseApiUrl}/{movieId}");
        }
        public async Task<Movie> GetMovieByNameAsync(string movieName)
        {
            return await _httpClient.GetFromJsonAsync<Movie>($"{BaseApiUrl}/{movieName}");
        }
    }
}
