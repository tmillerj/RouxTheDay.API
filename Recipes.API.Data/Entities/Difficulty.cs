using Postgrest.Models;

namespace Recipes.API.Data.Entities;

public class Difficulty : BaseModel
{
    public int DifficultyID { get; set; }
    public string DifficultyType { get; set; }
}