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
    public async Task<IEnumerable<RecipeDTO>> GetRecipes()
    {
        return await _recipeService.GetRecipes();
    }
}