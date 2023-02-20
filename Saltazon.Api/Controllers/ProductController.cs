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

        public async Task<ActionResult> GetProductsAsync()
        {
            try
            {
                var products = await _storeClient.GetAllProducts();

                return Ok(products);
            }
            catch (Exception ex)
            {
                return NotFound(ex.ToString());
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetProductAsync(int id)
        {
            try
            {
                var product = await _storeClient.GetProduct(id);

                return Ok(product);
            }
            catch (Exception ex)
            {
                return NotFound(ex.ToString());
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProductAsync(int id)
        {
            await _storeClient.DeleteProduct(id);
            return NoContent();
        }
    }
}
