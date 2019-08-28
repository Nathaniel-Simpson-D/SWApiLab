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
        
        public async Task<RootPersonArr> GetRootPerson()
        {
            var client = new HttpClient();
            
           
           client.BaseAddress = new Uri("https://swapi.co/api/people/");
            var response = await client.GetAsync($"");
            
            
            var person = await response.Content.ReadAsAsync<RootPersonArr>();

            return person;
        }
        public async Task<RootPerson> GetRootPerson(int id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri($"https://swapi.co/api/people/{id}/?format=json");
            var response = await client.GetAsync($"");
            var person = await response.Content.ReadAsAsync<RootPerson>();

            return person;
        }
        public async Task<RootPlanetArr> GetRootPlanet()
        {
            var client = new HttpClient();


            client.BaseAddress = new Uri("https://swapi.co/api/planets/");
            var response = await client.GetAsync($"");


            var person = await response.Content.ReadAsAsync<RootPlanetArr>();

            return person;
        }
        public async Task<RootPlanet> GetRootPlanet(int id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri($"https://swapi.co/api/planets/{id}/?format=json");
            var response = await client.GetAsync($"");
            var person = await response.Content.ReadAsAsync<RootPlanet>();

            return person;
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
            var persons = GetRootPerson().Result;
            return View(persons);
        }
        public IActionResult DisplayPerson(int id)
        {
            var person = GetRootPerson(id).Result;
            return View(person);
        }
        public IActionResult SelectPlanet()
        {
            var planets = GetRootPlanet().Result;
            return View(planets);
        }
        public IActionResult DisplayPlanet(int id)
        {
            var person = GetRootPlanet(id).Result;
            return View(person);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
