using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyMVCApplication.Models
{
    public class TouristContext: DbContext
    {
        public DbSet<Travel> Tourists { get; set; }
    }
}