using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AnnotationDemo.cs
{
    public class Employee
    {
        [Required(ErrorMessage= "Emloyee {0} is Requried")]
        [StringLength(100, MinimumLength =3, ErrorMessage ="Name should be minimum 3 charcter & maximum 100")]
        [DataType(DataType.Text)]
        public string Name { get; set; }


        [Range(18, 99, ErrorMessage ="Age should be above 18")]
        public int Age { get; set; }


        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string PhoneNumber { get; set; }


        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
    }
}
