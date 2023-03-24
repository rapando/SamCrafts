using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SamCrafts.Website.Models;
using SamCrafts.Website.Services;

namespace SamCrafts.Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileProductsService ProductService;
        public IEnumerable<Product> Products { get; private set; }

        public IndexModel(
            ILogger<IndexModel> logger,
            JsonFileProductsService productsService
            )
        {
            _logger = logger;
            ProductService = productsService;
        }

        public void OnGet()
        {
            Products = ProductService.GetProducts();

        }
    }
}