using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EntityFrameWorkCore2.Models;

namespace EntityFrameWorkCore2.Models
{
    public class Product1DBC : DbContext
    {
        public Product1DBC()
        {

        }
        public Product1DBC(DbContextOptions<Product1DBC> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=RYZEN5STEVEN;Initial Catalog=tasks;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");
        }
        public virtual DbSet<Product1> Products { get; set; }


    }
}