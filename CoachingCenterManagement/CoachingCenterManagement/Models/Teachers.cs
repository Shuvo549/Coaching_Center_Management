using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CoachingCenterManagement.Models
{
    public class Teachers
    {
        [Key]
        public int TeacherID { get; set; }

        public string Name { get; set; }

        public string Subject { get; set; }

        public string Email { get; set; }
    }
}