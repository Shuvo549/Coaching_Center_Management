using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoachingCenterManagement.Models
{
    public class Students
    {
        [Key]
        public int StudentID { get; set; }

        [Required(ErrorMessage ="Student Roll is required")]
        public int StudentRoll { get; set; }

        [Required(ErrorMessage = "Student Name is required")]
        public string StudentName { get; set; }
        [StringLength(14,MinimumLength = 7, ErrorMessage ="Phone number minimum length is 7 maximum length is 14")]
        [Required(ErrorMessage = "Student Phone is required")]
        public string phone { get; set; }

        [Required(ErrorMessage = "Student Address is required")]
        public string Address { get; set; }

        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage ="Invalid Email")]
        [Remote("IsEmailExists","Students",ErrorMessage = "Email already exists!")]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Blood Group is required")]
        public string BloodGroup { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Religion is required")]
        public string Religion { get; set; }

        [Required(ErrorMessage = " Nationality is required")]
        public string Nationality { get; set; }

    }
}