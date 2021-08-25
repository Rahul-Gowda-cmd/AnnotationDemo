using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace AnnotationDemo.cs
{
    public class AnnotationTest
    {
        public static void Disply()
        {
            Console.WriteLine("Employee class validation\n");

            Employee objEmployee = new Employee();

            objEmployee.Name = "Rahul";
            objEmployee.Age = 19;
            objEmployee.PhoneNumber = "922332333";
            objEmployee.Email = "Rahul.prabu@gamil.com";

            //validate object
            ValidationContext Context = new ValidationContext(objEmployee, null, null);
            //List for error messages
            List<ValidationResult> results = new List<ValidationResult>();
            //return whether validation is correct or not
            bool Valid = Validator.TryValidateObject(objEmployee, Context, results, true);

            if (!Valid)
            {
                //if invalid print error messages
                foreach (ValidationResult TotalResult in results)
                {
                    Console.WriteLine("Member Name :{0} ", TotalResult.MemberNames.First(), Environment.NewLine);
                    Console.WriteLine("Error Message :: {0}{1} ", TotalResult.ErrorMessage, Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine("Name: " + objEmployee.Name + "\n" + "Age :" + objEmployee.Age + "\n" + "PhoneNumber :" + objEmployee.PhoneNumber  + "\n" + "Email :" + objEmployee.Email + "\n");
            }
            Console.WriteLine("\n Pree any key to exit");
            Console.ReadKey();
        }
    }
}
