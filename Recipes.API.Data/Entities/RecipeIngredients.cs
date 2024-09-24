using Supabase.Postgrest.Attributes;

namespace Recipes.API.Data.Entities;

[Table("recipe_ingredients")]
public class RecipeIngredients
{
    [PrimaryKey("recipe_ingredients_id")]
    public int RecipeIngredientsId { get; set; }
    [Column("recipe_id")]
    public int RecipeId { get; set; }
    [Column("measurement_unit_id")]
    public int MeasurementUnitsId { get; set; }
    [Column("ingredients_id")]
    public int IngredientsId { get; set; }
    [Column("quantity")]
    public int Quantity { get; set; }
}