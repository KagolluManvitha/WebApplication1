
using Graphql_project.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Graphql_project 
{
    public class PlanItDBContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public PlanItDBContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Cake>Cake{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseNpgsql("Host=localhost; Database=Planitdbdummy; Username=postgres; Password=12345");
        }
        /*public PlanItDBContext(DbContextOptions<PlanItDBContext> options) : base(options)
        {
        }*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cake>().HasData(
                new Cake
                {
                    Id = 1,
                    name = "Jay krishna Reddy",

                },
                new Cake
                {
                    Id = 2,
                    name = "JK"

                },
                new Cake
                {
                    Id = 3,
                    name = "Jay",

                },
                 new Cake
                 {
                     Id = 4,
                     name = "krishna Reddy",

                 },
                 new Cake
                 {
                     Id = 5,
                     name = "Reddy",

                 }
                );
        }

    }
}
