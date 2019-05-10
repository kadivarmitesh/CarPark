using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using CarPark.Models;

namespace CarPark.Controllers
{
    public class CarParkController : Controller
    {
        List<CarParkData> lst = new List<CarParkData>();
        public async Task<ActionResult> Index()
        {
            Uri uri = new System.Uri("https://sps-opendata.pilotsmartke.gov.hk/rest/getCarparkInfos");

            HttpClient _httpClient = new HttpClient();
            var response = await _httpClient.GetAsync(uri, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();
            var data = await response.Content.ReadAsStringAsync();
            CarParkData carParkData =  JsonConvert.DeserializeObject<CarParkData>(data);
            
            return View(carParkData);
        }


        
        private static JsonSerializerSettings MicrosoftDateFormatSettings
        {
            get
            {
                return new JsonSerializerSettings
                {
                    DateFormatHandling = DateFormatHandling.MicrosoftDateFormat
                };
            }
        }
    }
}