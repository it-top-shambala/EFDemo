using System.ComponentModel.DataAnnotations.Schema;

namespace EFDemo.DB_Lib.Models;

[Table("table_persons")]
public class Person
{
    [Column("person_id")]
    public int PersonId { get; set; }
    
    [Column("first_name")]
    public string? FirstName { get; set; }
    
    [Column("last_name")]
    public string? LastName { get; set; }

    public virtual List<User>? Users { get; set; }
}