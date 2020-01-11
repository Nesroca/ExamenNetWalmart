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
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Error = "";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Login user)
        {
            User Usuario = new User();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44365/");
            var values = new Dictionary<string, string>();
            values.Add("Correo", user.Email);
            values.Add("Password", user.Password);
            var content = new FormUrlEncodedContent(values);

            HttpResponseMessage res = await client.PostAsync("api/Login/Login", content);
            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                Usuario = JsonConvert.DeserializeObject<User>(result);
                if (Usuario != null)
                    Response.Redirect("/Products", false);
                else
                    ViewBag.Error = "Usuario invalido";
            }
            return View();
        }

    }
}