using Postgrest.Models;

namespace Recipes.API.Data.Entities;

public class Cuisine : BaseModel
{
    public int CuisineId { get; set; }
    public string CuisineType { get; set; }
}