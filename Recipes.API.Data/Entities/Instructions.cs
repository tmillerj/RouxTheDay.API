using Postgrest.Models;

namespace Recipes.API.Data.Entities;

public class Instructions : BaseModel
{
    public int InstructionsId { get; set; }
    public string InstructionsSummary { get; set; }
}