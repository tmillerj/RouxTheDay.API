using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using Recipes.API.Domain;
using Recipes.API.Domain.DTO;

namespace Recipes.API.Controllers;

[Route("api/v{version:apiVersion}/recipes")]
[ApiController]
public class RecipeController : ControllerBase
{
    private readonly IRecipeService _recipeService;

    public RecipeController(IRecipeService recipeService)
    {
        _recipeService = recipeService;
    }

    [HttpGet]
    [ApiVersion("1.0")]
    public async Task<IEnumerable<RecipeDTO>> GetRecipes()
    {
        return await _recipeService.GetRecipes();
    }
    
    //GET api/v1.0/recipes/{id}
    [HttpGet("{id}")]
    [ApiVersion("1.0")]
    public async Task<ActionResult<RecipeDTO>> Get(int id)
    {
        return await _recipeService.GetRecipeById(id);
    }
}