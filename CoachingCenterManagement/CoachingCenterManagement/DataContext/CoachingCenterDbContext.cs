using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CoachingCenterManagement.Models;
using System.Data.Entity;

namespace CoachingCenterManagement.DataContext
{
    public class CoachingCenterDbContext:DbContext
    {
        public DbSet<Students> Students  { get; set; }
        public DbSet<Teachers> Teachers { get; set; }
        public DbSet<Admission> Admission { get; set; }
        public DbSet<Registers> Registers { get; set; }


    }
}