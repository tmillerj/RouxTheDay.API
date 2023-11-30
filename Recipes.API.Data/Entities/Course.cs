using Postgrest.Models;

namespace Recipes.API.Data.Entities;

public class Course : BaseModel
{
    public int CourseId { get; set; }
    public string CourseType { get; set; }
}