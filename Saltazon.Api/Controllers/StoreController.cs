using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Saltazon.Api.Models;
using Saltazon.Api.Services;

namespace Saltazon.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly IStoreClient _storeClient;

        public StoreController(IStoreClient storeClient) { _storeClient = storeClient; }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetStoreAsync(int id)
        {
            try
            {
                var store = await _storeClient.GetStore(id);

                return Ok(store);
            }
            catch (Exception ex)
            {
                return NotFound(ex.ToString());
            }
        }

        [HttpGet("{id}/product")]
        public async Task<ActionResult> GetProductsInStore(int id)
        {
            try
            {
                var products = await _storeClient.GetAllProducts();

                var result = products?.Products.Where(p => p.StoreId == id);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return NotFound(ex.ToString());
            }
        }

        [HttpPost("{id}/product")]
        public async Task<ActionResult> PostProductAsync(ProductRegisterRequest product)
        {
            var result = await _storeClient.Register(product);
            return Created("", product);
        }
    }
}
