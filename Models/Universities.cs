using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Universities_List_Project.Models
{
    //public class Universities
    //{
    //    public University[] Colleges { get; set; }
    //}

    public class University
    {
        public string[] Domains { get; set; }
        public string[] Web_pages { get; set; }
        public string Name { get; set; }
        public string Alpha_two_code { get; set; }
        public string Stateprovince { get; set; }
        public string Country { get; set; }
    }
}








