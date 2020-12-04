using Domain.Enums;

namespace Domain.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; } 
    }
}
