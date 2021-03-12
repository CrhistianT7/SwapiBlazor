using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StarWarsSearcher.Entities
{
    public class Character
    {
        public string Name { get; set; }
        public string Height { get; set; }
        [JsonPropertyName("hair_color")]
        public string HairColor { get; set; }
        [JsonPropertyName("skin_color")]
        public string SkinColor { get; set; }
        public string Mass { get; set; }
        [JsonPropertyName("eye_color")]
        public string EyeColor { get; set; }
        [JsonPropertyName("birth_year")]
        public string BirthYear { get; set; }
        public string Gender { get; set; }
        public string[] Films { get; set; }
    }
}
