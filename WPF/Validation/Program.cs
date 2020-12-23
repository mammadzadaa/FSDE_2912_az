using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Validation
{
    class AuthorAttribute : Attribute
    {
        public string Name { get; set; }
        public AuthorAttribute(string name)
        {
            Name = name;
        }
    }

    class PassportNumberAttribute : ValidationAttribute
    {
        public string Prefix { get; set; }
        public override bool IsValid(object value)
        {
            if (value is string passportNumber)
            {
                var regx = new Regex("^[A-Z]{2}[0-9]{7}$");
                var isRegexMatch = regx.IsMatch(passportNumber);

                if (isRegexMatch)
                {
                    if (!string.IsNullOrEmpty(Prefix))
                    {
                        return passportNumber.StartsWith(Prefix);
                    }
                    return true;
                }
         
            }
            return false;
        }
    }

    class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(x => x.Model)
                .NotEmpty()
                .MinimumLength(2)
                .WithMessage("Model name is too short!");

            RuleFor(x => x.Manufacturer)
                .NotEmpty()
                .MinimumLength(2)
                .WithMessage("Manufacturer name is too short!");
            RuleFor(x => x.HP)
                .NotEmpty()
                .ExclusiveBetween(1, 1000)
                .WithMessage("Hp is out of range!");
        }
    }

    class Car
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int HP { get; set; }
    }

    class Person
    {
        [Author ("Agil")]
        [Required]
        [MinLength(2)]
        public string Name { get; set; }
        
        public string Surname { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }

        [Required]
        [PassportNumber(Prefix = "AA")]
        public string PasportNumber { get; set; }

        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car()
            {
                Manufacturer = "BMW",
                Model = "P1",
                HP = 123
            };

            var carValidator = new CarValidator();
            var result = carValidator.Validate(car);

            Console.WriteLine($"Is Valid : {result.IsValid}");
            foreach (var error in result.Errors)
            {
                Console.WriteLine(error.ErrorMessage);
            }

            //var person = new Person()
            //{
            //    Name = "aa32131",
            //    Surname = "Mammadov",
            //    Email = "afti@mail.ru",
            //    Phone ="4903327327",
            //    PasportNumber = "AA1234567",
            //    Age = 45
            //};

            //var context = new ValidationContext(person);

            //var results = new List<ValidationResult>();
            //var isValid =  Validator.TryValidateObject(person, context, results, true);

            //if (!isValid)
            //{
            //    foreach (var result in results)
            //    {
            //        Console.WriteLine(result.ErrorMessage);
            //    }
            //}

            // Reflection
            //var personType = typeof(Person);
            //foreach (var propertyInfo in personType.GetProperties())
            //{
            //    Console.WriteLine(propertyInfo.Name);
            //    foreach (var attribute in propertyInfo.CustomAttributes)
            //    {
            //        Console.WriteLine(" -  " + attribute);
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
