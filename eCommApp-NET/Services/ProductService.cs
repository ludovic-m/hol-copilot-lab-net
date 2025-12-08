using System.Net.Http.Json;
using eCommApp_NET.Models;

namespace eCommApp_NET.Services;

public class ProductService
{
    private readonly HttpClient _httpClient;

    public ProductService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Product>> GetProductsAsync()
    {
        var products = new List<Product>();
        var productFiles = new[] { "apple.json", "grapes.json", "orange.json", "pear.json" };

        foreach (var file in productFiles)
        {
            try
            {
                var product = await _httpClient.GetFromJsonAsync<Product>($"products/{file}");
                if (product != null)
                {
                    products.Add(product);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading {file}: {ex.Message}");
            }
        }

        return products;
    }
}
