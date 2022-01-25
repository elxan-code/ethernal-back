using etheralback.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace etheralback.Data
{
    public class AppDbContext:IdentityDbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Settings> Settings { get; set; }
        public DbSet<CustomUser> CustomUsers { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Testerminalcs> Testerminalcss { get; set; }
       


    }
}
