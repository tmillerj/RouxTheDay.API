using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace Recipes.API.Data.Entities;

[Table("ingredient")]
public class Ingredient : BaseModel
{
    [PrimaryKey("ingredient_id")]
    public int IngredientId { get; set; }
    [Column("ingredient_name")]
    public string IngredientName { get; set; }
}