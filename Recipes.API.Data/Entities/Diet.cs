using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace Recipes.API.Data.Entities;

[Table("diet")]
public class Diet : BaseModel
{
    [PrimaryKey("diet_id")]
    public int DietID { get; set; }
    [Column("diet_type")]
    public string DietType { get; set; }
}