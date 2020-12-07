using Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    [Table("TablaPersona")]
    public class Person
    {
        [Column("id")]
        public int PersonId { get; set; }
        [Column("Dscription")]
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; } 
    }
}
