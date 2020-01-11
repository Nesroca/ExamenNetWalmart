using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ExamenNet.WebMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ExamenNet.WebMVC.Controllers
{
    public class ProductsController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<Products> Productos = new List<Products>();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44365/");
            HttpResponseMessage res = await client.GetAsync("api/Product/Products");
            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                Productos = JsonConvert.DeserializeObject<List<Products>>(result);
            }
            return View(Productos);
        }
    }
}