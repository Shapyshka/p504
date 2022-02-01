using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RealExamWork.Models
{
    public class Tovar
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class MyContext : DbContext
    {
        public DbSet<Tovar> Tovars { get; set; }
    }
}