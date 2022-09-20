using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace FoodjiApi.Controllers;

[ApiController]
[Route(("ingredients"))]
public class IngredientsController : ControllerBase
{
    private readonly IMongoClient _dbClient;

    public IngredientsController(IMongoClient dbClient)
    {
        _dbClient = dbClient;
    }

    [HttpGet]
    public IEnumerable<string> GetAllIngredients()
    {
        return Enumerable.Empty<string>();
    }
}