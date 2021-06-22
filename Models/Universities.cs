using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Universities_List_Project.Models
{
    public class Universities
    {
         
      
            public List<string> web_pages { get; set; }
            public string name { get; set; }
            public string alpha_two_code { get; set; }

            [JsonProperty("state-province")]
            public string StateProvince { get; set; }
            public List<string> domains { get; set; }
            public string country { get; set; }
        

    }
}
