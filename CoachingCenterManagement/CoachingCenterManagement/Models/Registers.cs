using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoachingCenterManagement.Models
{
    public class Registers
    {
        [Key]
        public int userId { get; set; }

       [Required(ErrorMessage ="FirstName is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName is required")]
        public string LastName { get; set; }

        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Invalid Email")]
        [Remote("IsEmailExists", "Students", ErrorMessage = "Email already exists!")]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [StringLength(100,MinimumLength = 8, ErrorMessage = "Password minimum 8 character")]
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [System.ComponentModel.DataAnnotations.Compare("Password",ErrorMessage = "Password does not match")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "ConfirmPassword is required")]
        public string ConfirmPassword { get; set; }

    }
}