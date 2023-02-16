using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Saltazon.Api.Models;
using Saltazon.Api.Services;

namespace Saltazon.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IStoreClient _storeClient;

        public ProductController(IStoreClient storeClient)
        {
            _storeClient = storeClient;
        }

        [HttpGet]

        public async Task<ActionResult<ProductListResponse>> GetProductsAsync()
        {
            try
            {
                var products = await _storeClient.GetAllProducts();

                return products;
            }
            catch (Exception ex)
            {
                return NotFound(ex.ToString());
            }
        }
    }
}
