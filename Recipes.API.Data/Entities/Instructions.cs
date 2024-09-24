using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace Recipes.API.Data.Entities;

[Table("instructions")]
public class Instructions : BaseModel
{
    [PrimaryKey("instructions_id")]
    public int InstructionsId { get; set; }
    [Column("instructions_summary")]
    public string InstructionsSummary { get; set; }
}