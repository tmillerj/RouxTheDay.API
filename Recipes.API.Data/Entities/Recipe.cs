using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace Recipes.API.Data.Entities;

[Table("recipe")]
public class Recipe : BaseModel
{
    [PrimaryKey("recipe_id")]
    public int RecipeId { get; set; }
    
    [Column("recipe_name")]
    public string RecipeName { get; set; }
    
    [Column("recipe_notes")]
    public string RecipeNotes { get; set; }
    
    [Column("created_at")]
    public DateTime CreatedAt { get; set; }
    
    [Reference(typeof(Ingredient))]
    public List<Ingredient> Ingredients { get; set; }
    
    [Reference(typeof(Difficulty))]
    public Difficulty Difficulty { get; set; }
    
    [Reference(typeof(Cuisine))]
    public Cuisine Cuisine { get; set; }
    
    [Reference(typeof(Diet))]
    public Diet Diet { get; set; }
    
    [Reference(typeof(Instructions))]
    public List<Instructions> Instructions { get; set; }
    
    [Reference(typeof(Course))]
    public Course Course { get; set; }
}