using Domain.Models;
using FluentValidation;

namespace Infraestructure.Validators
{
    public class PersonValidation : AbstractValidator<Person>
    {
        public PersonValidation()
        {
            RuleFor(person => person.PersonId).NotEmpty().NotNull();
            RuleFor(person => person.Name).NotEmpty().NotNull();
            RuleFor(person => person.Age).NotEmpty().NotNull().NotEqual(0);
            RuleFor(person => person.Gender).NotEmpty().NotNull();
        }
    }
}
