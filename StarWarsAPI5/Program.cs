using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using StarWarsAPI5.Services;
using StarWarsSearcher.Entities;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsAPI5
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://swapi.dev/api/") });
            builder.Services.AddHttpClient<IPeopleDataService, PeopleDataService>(client => client.BaseAddress = new Uri("https://swapi.dev/api/"));
            builder.Services.AddHttpClient<IFilmDataService, FilmDataService>(client => client.BaseAddress = new Uri("https://swapi.dev/api/"));
            builder.Services.AddHttpClient<IPlanetDataService,PlanetDataService>(client => client.BaseAddress = new Uri("https://swapi.dev/api/"));
            builder.Services.AddHttpClient<ISpecieDataService, SpecieDataService>(client => client.BaseAddress = new Uri("https://swapi.dev/api/"));
            builder.Services.AddHttpClient<IStarshipDataService, StarshipDataService>(client => client.BaseAddress = new Uri("https://swapi.dev/api/"));
            builder.Services.AddHttpClient<IVehicleDataService, VehicleDataService>(client => client.BaseAddress = new Uri("https://swapi.dev/api/"));
            builder.Services.AddHttpClient<IDataService<Character>, DataService<Character>>(client => client.BaseAddress = new Uri("https://swapi.dev/api/"));
            builder.Services.AddHttpClient<IDataService<Film>, DataService<Film>>(client => client.BaseAddress = new Uri("https://swapi.dev/api/"));
            builder.Services.AddHttpClient<IDataService<Planet>, DataService<Planet>>(client => client.BaseAddress = new Uri("https://swapi.dev/api/"));
            builder.Services.AddHttpClient<IDataService<Specie>, DataService<Specie>>(client => client.BaseAddress = new Uri("https://swapi.dev/api/"));
            builder.Services.AddHttpClient<IDataService<Starship>, DataService<Starship>>(client => client.BaseAddress = new Uri("https://swapi.dev/api/"));
            builder.Services.AddHttpClient<IDataService<Vehicle>, DataService<Vehicle>>(client => client.BaseAddress = new Uri("https://swapi.dev/api/"));


            await builder.Build().RunAsync();
        }
    }
} 
