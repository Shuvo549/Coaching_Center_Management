using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CoachingCenterManagement.Models
{
    public class Admission
    {
        [Key]
        public int SlNo { get; set; }

        [Required(ErrorMessage = "FirstName is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "DateOfBirth is required")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Class is required")]
        public int Class { get; set; }

        [Required(ErrorMessage = "FatherName is required")]
        public string FatherName { get; set; }

        [Required(ErrorMessage = "MotherName is required")]
        public string MotherName { get; set; }

        [Required(ErrorMessage = "PermanentAddress is required")]
        public string PermanentAddress { get; set; }

        [StringLength(14, MinimumLength = 7, ErrorMessage = "Phone number minimum length is 7 maximum length is 14")]
        [Required(ErrorMessage = "PhoneNumber is required")]
        public string PhoneNumber { get; set; }
    }
}