using Recipes.API.Data.Entities;

namespace Recipes.API.Domain.DTO;

public class RecipeDTO
{
    public string RecipeName { get; set; }
    public string RecipeNotes { get; set; }
    public DateTime CreatedDate { get; set; }
    public List<Ingredient> Ingredients { get; set; }
    public Difficulty Difficulty { get; set; }
    public Cuisine Cuisine { get; set; }
    public Diet Diet { get; set; }
    public List<Instructions> InstructionsList { get; set; }
    public Course Course { get; set; }
}