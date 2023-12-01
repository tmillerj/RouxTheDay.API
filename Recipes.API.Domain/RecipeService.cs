using AutoMapper;
using Recipes.API.Data;
using Recipes.API.Data.Entities;
using Recipes.API.Domain.DTO;

namespace Recipes.API.Domain;

public interface IRecipeService
{
    Task<IEnumerable<RecipeDTO>> GetRecipes();
}

public class RecipeService
{
    private readonly IRecipesRepository _repository;
    private readonly IMapper _mapper;

    public RecipeService(IRecipesRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<RecipeDTO>> GetRecipes()
    {
        List<Recipe> recipes =  await _repository.GetRecipes();

        return recipes.Any() ? _mapper.Map<List<Recipe>, List<RecipeDTO>>(recipes) : null;
    }
}