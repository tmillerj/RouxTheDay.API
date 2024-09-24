using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace Recipes.API.Data.Entities;

[Table("cuisine")]
public class Cuisine : BaseModel
{
    [PrimaryKey("cuisine_id")]
    public int CuisineId { get; set; }
    [Column("cuisine_type")]
    public string CuisineType { get; set; }
}