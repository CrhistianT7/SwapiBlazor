using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StarWarsSearcher.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace StarWarsAPI5.Models
{
    /*public class AppDbContext: IdentityDbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        [Inject] HttpClient Http { get; set; }
        public DbSet<Character> People { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Planet> Planets { get; set; }
        public DbSet<Specie> Species { get; set; }
        public DbSet<Starship> Starships { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

        protected override async void OnModelCreating(ModelBuilder modelBuilder)
        {
            var people = new IEnumerable<Character>();
            base.OnModelCreating(modelBuilder);
            try
            {
                var response = await Http.GetFromJsonAsync<SwapiListResponse<Character>>(Http.BaseAddress.ToString() + "people/");
                people = response.Results;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            modelBuilder.Entity<Character>().HasData(people);
            base.OnModelCreating(modelBuilder);
        }
    }*/
}
