using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace Recipes.API.Data.Entities;

[Table("course")]
public class Course : BaseModel
{
    [PrimaryKey("course_id")]
    public int CourseId { get; set; }
    [Column("course_type")]
    public string CourseType { get; set; }
}