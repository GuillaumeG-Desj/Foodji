using Microsoft.AspNetCore.Mvc;

namespace FoodjiApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecipesController : ControllerBase
    {
        private readonly ILogger<RecipesController> _logger;

        public RecipesController(ILogger<RecipesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> GetAllRecipes()
        {
            return Enumerable.Empty<string>();
        }
    }
}