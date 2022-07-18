using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShaqTamra.DAL.Entity;
using ShaqTamra.DAL.Extrnal;

namespace ShaqTamra.DAL.DataBase
{
   public  class ShaqTamraContext:IdentityDbContext<ApplicationUser>
    {
        public ShaqTamraContext(DbContextOptions<ShaqTamraContext>opt):base (opt)
        {

        }
        public DbSet<Like> Like { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<volunteerRequest> volunteerRequest { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Beneficiaryrequests> Beneficiaryrequests { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"server = DESKTOP-39BJCN6\SQLEXPRESS ; database = ShaqTamra; Integrated Security = true");
        //}

    }
}
