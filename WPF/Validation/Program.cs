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
            var person = new Person()
            {
                Name = "aa32131",
                Surname = "Mammadov",
                Email = "afti@mail.ru",
                Phone ="4903327327",
                PasportNumber = "AA1234567",
                Age = 45
            };

            var context = new ValidationContext(person);

            var results = new List<ValidationResult>();
            var isValid =  Validator.TryValidateObject(person, context, results, true);

            if (!isValid)
            {
                foreach (var result in results)
                {
                    Console.WriteLine(result.ErrorMessage);
                }
            }

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
