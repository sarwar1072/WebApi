using Microsoft.AspNetCore.Mvc;
using WebAPI.Web.Models.VillaModel;
using System.Text.Json.Serialization;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace ConsumeAPI.Controllers
{
    public class ConsumeController : Controller
    {
        private string localURL = "https://localhost:44340";
        public IActionResult Index()
        {
            List<House> data = new List<House>();
            try
            {
                using (HttpClient client = new HttpClient()) {
                    client.BaseAddress = new Uri(localURL);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage message = client.GetAsync("/api/House/GetAll").Result;
                    client.Dispose();
                    if (message.IsSuccessStatusCode)
                    {
                        string stringData=message.Content.ReadAsStringAsync().Result;   
                        data=JsonConvert.DeserializeObject<List<House>>(stringData);
                    }
                    else
                    {
                        TempData["error"] =$"{message.ReasonPhrase}";
                    }
                }
            }
            catch(Exception ex)
            {
                TempData["exception"]=ex.Message;
            }
            return View(data);
        }


    }
}
