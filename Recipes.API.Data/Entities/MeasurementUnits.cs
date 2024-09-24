using Supabase.Postgrest.Attributes;

namespace Recipes.API.Data.Entities;

[Table("measurement_units")]
public class MeasurementUnits
{
    [PrimaryKey("measurement_unit_id")]
    public int MeasurementUnitId { get; set; }
    [Column("measurement_description")]
    public string MeasurementDescription { get; set; }
}