using System.ComponentModel.DataAnnotations.Schema;

namespace EFDemo.DB_Lib.Models;

[Table("table_users")]
public class User
{
    [Column("user_id")]
    public int UserId { get; set; }
    
    [Column("person_id")]
    public int PersonId { get; set; }
    public virtual Person? Person { get; set; }
    
    [Column("login")]
    public string? Login { get; set; }
}