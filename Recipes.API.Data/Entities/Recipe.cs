using Postgrest.Models;

namespace Recipes.API.Data.Entities;

public class Recipe : BaseModel
{
    public int RecipeId { get; set; }
    public string RecipeName { get; set; }
    public string RecipeNotes { get; set; }
    public DateTime CreatedAt { get; set; }
    public List<Ingredient> Ingredients { get; set; }
    public Difficulty Difficulty { get; set; }
    public Cuisine Cuisine { get; set; }
    public Diet diet { get; set; }
    public List<Instructions> instructions { get; set; }
    public Course Course { get; set; }
}