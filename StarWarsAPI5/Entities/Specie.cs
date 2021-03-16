using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StarWarsSearcher.Entities
{
    public class Specie
    {
        public string Name { get; set; }
        public string Classification { get; set; }
        public string Designation { get; set; }
        [JsonPropertyName("average_height")]
        public string AverageHeight { get; set; }
        [JsonPropertyName("skin_colors")]
        public string SkinColors { get; set; }
        [JsonPropertyName("hair_colors")]
        public string HairColors { get; set; }
        [JsonPropertyName("eye_colors")]
        public string EyeColors { get; set; }
        [JsonPropertyName("average_lifespan")]
        public string AverageLifespan { get; set; }
        public string Homeworld { get; set; }
        public string Language { get; set; }
        public List<string> People { get; set; }
        public List<string> Films { get; set; }
        public string Created { get; set; }
        public string Edited { get; set; }
        public string Url { get; set; }
    }
}
