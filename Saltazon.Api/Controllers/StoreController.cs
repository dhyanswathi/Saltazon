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
        public async Task<ActionResult<StoreResponse>> GetStoreAsync(int id)
        {
            try
            {
                var store = await _storeClient.GetStore(id);

                return store;
            }
            catch (Exception ex)
            {
                return NotFound(ex.ToString());
            }
        }
    }
}
