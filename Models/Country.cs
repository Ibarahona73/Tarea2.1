using System.Collections.Generic;

namespace Tarea2._1.Models
{
    public class Country
    {
        public string name { get; set; }
        public string capital { get; set; }
        public string region { get; set; }
        public string flag { get; set; }
        public Dictionary<string, string> languages { get; set; }
        public double area { get; set; }
    }
}
