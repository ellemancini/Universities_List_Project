using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Universities_List_Project.Models;
using Newtonsoft.Json;

namespace Universities_List_Project.Controllers
{
    public class HomeController : Controller
    {
        HttpClient httpClient;
        static string BASE_URL = "http://universities.hipolabs.com/search?country";

        //public object JsonConvert { get; private set; }

        //https://apipheny.io/free-api/
        //world_universities_and_domains.json

        public IActionResult Index()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            string UNIVERSITIES_LIST_PROJECT_PATH = BASE_URL;// + "search?country";
            string universitiesData = "";

            //Universities_List_Project.Models.Universities College = null;
            List<University> College = null;

            httpClient.BaseAddress = new Uri(UNIVERSITIES_LIST_PROJECT_PATH);

            try
            {
                HttpResponseMessage response = httpClient.GetAsync(UNIVERSITIES_LIST_PROJECT_PATH).GetAwaiter().GetResult();
                if (response.IsSuccessStatusCode)
                {
                    universitiesData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                }

                if (!universitiesData.Equals(""))
                {
                    // JsonConvert is part of the NewtonSoft.Json Nuget package
                    College = JsonConvert.DeserializeObject<List<University>>(universitiesData);
                }
            }
            catch (Exception e)
            {
                // This is a useful place to insert a breakpoint and observe the error message
                Console.WriteLine(e.Message);
            }
            return View(College);

        }
    }
}