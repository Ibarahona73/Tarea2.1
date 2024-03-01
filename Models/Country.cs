using System.Collections.Generic;
using Newtonsoft.Json;
namespace Tarea2._1.Models
{
    public class Country
    {
        public class Name
        {
            [JsonProperty("common")]
            public string Common { get; set; }

            [JsonProperty("official")]
            public string Official { get; set; }

            [JsonProperty("nativeName")]
            public Dictionary<string, Dictionary<string, string>> NativeName { get; set; }
        }

        public string name { get; set; }
        public string capital { get; set; }
        public string region { get; set; }
        public string flag { get; set; }
        public Dictionary<string, string> languages { get; set; }
        public double area { get; set; }
    }
}
