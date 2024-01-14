using AutoMapper;
using Recipes.API.Data;
using Recipes.API.Data.Entities;
using Recipes.API.Domain.DTO;

namespace Recipes.API.Domain;

public interface IRecipeService
{
    Task<IEnumerable<RecipeDTO>> GetRecipes();
    Task<RecipeDTO> GetRecipeById(int id);
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
        return _mapper.Map<List<Recipe>, List<RecipeDTO>>(await _repository.GetRecipes());
    }

    public async Task<RecipeDTO> GetRecipeById(int id)
    {
        return _mapper.Map<Recipe, RecipeDTO>(await _repository.GetRecipeById(id));
    }
}