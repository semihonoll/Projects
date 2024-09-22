using _86_API_GetPosts.Models;
using System.Text;
using System.Text.Json;

namespace _86_API_GetPosts.Services
{
    public class ApiServices
    {
        private readonly HttpClient _httpClient;

        public ApiServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<PostDb>> GetApiAllPosts()
        {
            string apiUrl = "https://jsonplaceholder.typicode.com/posts";

            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine($"Status Code: {response.StatusCode}");

                string responseData = await response.Content.ReadAsStringAsync();

                List<PostDb> posts = JsonSerializer.Deserialize<List<PostDb>>(responseData, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                return posts;
            }
            else
            {
                Console.WriteLine($"Status Code: {response.StatusCode}");
                throw new Exception("Data okunamadı...");
            }
        }

        public async Task<List<Category>> GetApiCategory()
        {
            string apiUrl = "https://localhost:7153/api/Categorys/Get";

            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine($"Status Code: {response.StatusCode}");

                string responseData = await response.Content.ReadAsStringAsync();

                List<Category> categories = JsonSerializer.Deserialize<List<Category>>(responseData, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                return categories;
            }
            else
            {
                Console.WriteLine($"Status Code: {response.StatusCode}");
                throw new Exception("Data okunamadı...");
            }
        }

        public async Task<CategoryDTO> PostApiCategory(CategoryDTO newCategory)
        {
            string apiUrl = "https://localhost:7153/api/Categorys/Create";

            string jsonCategory = JsonSerializer.Serialize(newCategory);

            var content = new StringContent(jsonCategory, Encoding.UTF8, "application/json");

            HttpResponseMessage reponse = await _httpClient.PostAsync(apiUrl, content);

            if (reponse.IsSuccessStatusCode)
            {
                Console.WriteLine($"Status Code: {reponse.StatusCode}");

                string responseData = await reponse.Content.ReadAsStringAsync();

                CategoryDTO createdCategory = JsonSerializer.Deserialize<CategoryDTO>(responseData, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                return createdCategory;
            }
            else 
            {
                Console.WriteLine($"Status Code: {reponse.StatusCode}");
                throw new Exception("Data oluşturulamadı.");
            }
        }
    }
}
