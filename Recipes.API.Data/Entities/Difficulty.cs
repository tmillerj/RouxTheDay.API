using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace Recipes.API.Data.Entities;

[Table("difficulty")]
public class Difficulty : BaseModel
{
    [PrimaryKey("difficulty_id")]
    public int DifficultyID { get; set; }
    [Column("difficulty_type")]
    public string DifficultyType { get; set; }
}