using System;
using Week2.Extensions;
using Week2.Extensions.Validators;
using Week2.Extensions.Abstract;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {

            string email = "asdasdfsfgsd1";
            Console.WriteLine(email.MultipleValidator(new Validate[] { new UpperCaseValidator(), new LowerCaseValidator(), new LengthValidator() }));
        }
    }
}
