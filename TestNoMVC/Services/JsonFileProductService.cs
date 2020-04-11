using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Hosting;
using TestNoMVCModels;

namespace TestNoMVC.WebSite.Services
{
    public class JsonFileProductService
    {
        //this is a contructor that starts the web host service being used in this service.
        public JsonFileProductService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        //then calls it onto the object
        public IWebHostEnvironment WebHostEnvironment { get; }

        //this method gets the json file.
        private string JsonFileName
        {
            //Routes the json file without hard coding the file url
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "products.json"); }
        }

        //this method returns a IEnumerable that can be used to quary
        //this method searches through the json file and adds the data to the product as a list.
        //IEnumerables can be thought as things that can be foreached over.
        public IEnumerable<Product> GetProducts()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Product[]>(jsonFileReader.ReadToEnd(),
                    //Optional this will say that you dont care about the case sense.
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }

    }

}