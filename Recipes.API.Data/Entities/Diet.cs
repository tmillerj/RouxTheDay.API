using Postgrest.Models;

namespace Recipes.API.Data.Entities;

public class Diet : BaseModel
{
    public int DietID { get; set; }
    public string DIetType { get; set; }
}