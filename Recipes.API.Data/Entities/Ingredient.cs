using Postgrest.Models;

namespace Recipes.API.Data.Entities;

public class Ingredient : BaseModel
{
    public int IngredientId { get; set; }
    public string IngredientName { get; set; }
}