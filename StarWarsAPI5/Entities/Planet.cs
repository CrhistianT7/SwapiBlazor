using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StarWarsSearcher.Entities
{
    public class Planet
    {
        public string Name { get; set; }
        [JsonPropertyName("rotation_period")]
        public string RotationPeriod { get; set; }
        [JsonPropertyName("orbital_period")]
        public string OrbitalPeriod { get; set; }
        public string Diameter { get; set; }
        public string Climate { get; set; }
        public string Gravity { get; set; }
        public string Terrain { get; set; }
        [JsonPropertyName("surface_water")]
        public string SurfaceWater { get; set; }
        public string Population { get; set; }
        public List<string> Residents { get; set; }
        public List<string> Films { get; set; }
        public string Created { get; set; }
        public string Edited { get; set; }
        public string Url { get; set; }

    }
}
