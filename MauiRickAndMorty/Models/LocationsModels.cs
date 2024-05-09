using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiRickAndMorty.Models
{
    public class LocationsModels
    {
        
            public int id { get; set; }
            public string name { get; set; }
            public string type { get; set; }
            public string dimension { get; set; }
            public List<string> residents { get; set; }
            public string url { get; set; }
            public DateTime created { get; set; }
        
    }
}
