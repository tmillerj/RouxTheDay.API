using Supabase.Postgrest;
using Supabase.Postgrest.Responses;
using Recipes.API.Data.Entities;

namespace Recipes.API.Data;

public interface IRecipesRepository
{
    Task<List<Recipe>> GetRecipes();
    Task<Recipe> GetRecipeById(int recipeId);
    Task Save(Recipe recipe);
    Task Update(int recipeId);
    Task Delete(int recipeId);
}

public class RecipesRepository : IRecipesRepository
{
    private readonly Client _client;

    public RecipesRepository(Supabase.Postgrest.Client client)
    {
        _client = client;
    }
    
    public async Task<List<Recipe>> GetRecipes()
    {
        var recipes = await _client
            .Table<Recipe>()
            .Get().ConfigureAwait(false);

        return recipes.Models;
    }

    public async Task<Recipe> GetRecipeById(int recipeId)
    {
        var response = await _client.Table<Recipe>()
            .Where(r => r.RecipeId == recipeId)
            .Get();
        return response.Model;
    }

    public Task Save(Recipe recipe)
    {
        return null;
    }

    public Task Update(int recipeId)
    {
        return null;
    }

    public Task Delete(int recipeId)
    {
        return null;
    }
}