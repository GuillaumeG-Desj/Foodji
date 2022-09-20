using Microsoft.AspNetCore.Mvc;

namespace FoodjiApi.Controllers;

[ApiController]
[Route("recipes")]
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
