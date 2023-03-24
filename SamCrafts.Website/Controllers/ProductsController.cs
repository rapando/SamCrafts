using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SamCrafts.Website.Models;
using SamCrafts.Website.Services;

namespace SamCrafts.Website.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public JsonFileProductsService ProductsService { get;}

        public ProductsController(JsonFileProductsService productsService) {
            this.ProductsService = productsService;
        }

        [HttpGet]
        public IEnumerable<Product> Get() {
            return ProductsService.GetProducts();
        }

        [Route("Rate")]
        [HttpPatch]
        public ActionResult Get(
            [FromQuery] string ProductId,
            [FromQuery] int Rating)
        {
            ProductsService.AddRating(ProductId, Rating);
            return Ok();
        }
    }
}
