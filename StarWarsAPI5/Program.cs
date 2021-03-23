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
            builder.Services.AddScoped<IDataService<Character>, DataService<Character>>();
            builder.Services.AddScoped<IDataService<Film>, DataService<Film>>();
            builder.Services.AddScoped<IDataService<Planet>, DataService<Planet>>();
            builder.Services.AddScoped<IDataService<Specie>, DataService<Specie>>();
            builder.Services.AddScoped<IDataService<Starship>, DataService<Starship>>();
            builder.Services.AddScoped<IDataService<Vehicle>, DataService<Vehicle>>();


            await builder.Build().RunAsync();
        }
    }
} 
