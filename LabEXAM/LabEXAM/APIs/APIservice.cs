using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using LabEXAM.Model;
using Newtonsoft.Json;

namespace LabEXAM.APIs
{
    class APIservice
    {
        HttpClient client;


        public APIservice()
        {
            client = new HttpClient();

        }

        public async Task<ObservableCollection<Product>> GetProducts()
        {
            ObservableCollection<Product> item = null;

            try
            {
                var response = await client.GetAsync("https://fakestoreapi.com/products");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    item = JsonConvert.DeserializeObject<ObservableCollection<Product>>(content);
                    return item;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            return null;
        }
    }
}
