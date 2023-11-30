namespace Recipes.API.Data.Entities;

public class RecipeIngredients
{
    public int RecipeIngredientsId { get; set; }
    public int RecipeId { get; set; }
    public int MeasurementUnitsId { get; set; }
    public int IngredientsId { get; set; }
    public int Quantity { get; set; }
}