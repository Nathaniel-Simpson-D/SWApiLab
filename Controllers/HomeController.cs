using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SWApiLab23.Models;


namespace SWApiLab23.Controllers
{
    public class HomeController : Controller
    {
        
        public async Task<SWApiLab23.ModelsRootPerson> GetRootPerson()
        {
           
            var client = new HttpClient();
            client.BaseAddress = new Uri("http https://swapi.co/api/people/1/");//Get From WebSite
            var YourKey = "1ef43060-a6c9-492b-ad8d-81debae3bea0";
            client.DefaultRequestHeaders.Add("x-api-key", YourKey);

            var response = await client.GetAsync($"/v1/breeds?attach_breed=0");
            var jsonData = response.Content.ToString();

            var catObject = await response.Content.ReadAsAsync<RootPerson>();

            return catObject;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TypeIdent(string perpan)
        {
            if(perpan == "Person")
            {
               return RedirectToAction("SelectPerson");
            }
            else
            {
               return RedirectToAction("SelectPlanet");
            }
        }
         public IActionResult SelectPerson()
        {
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
