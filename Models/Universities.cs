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
        public string[] domains { get; set; }
        public string[] web_pages { get; set; }
        public string name { get; set; }
        public string alpha_two_code { get; set; }
        public string stateprovince { get; set; }
        public string country { get; set; }
    }
}








