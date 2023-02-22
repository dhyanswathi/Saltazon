using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Saltazon.Api.Models;
using Saltazon.Api.Services;

namespace Saltazon.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
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

        [HttpGet]
        public async Task<ActionResult> GetStoresAsync()
        {
            try
            {
                var result = await _storeClient.GetAllStores();

                return Ok(result);
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
        public async Task<ActionResult> PostProductAsync(ProductRegisterRequest product, int id)
        {
            var result = await _storeClient.Register(product, id);
            return Created("", result);
        }
    }
}
