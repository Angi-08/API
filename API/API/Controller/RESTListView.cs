using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using API.Model;
using Newtonsoft.Json;

namespace API.Controller
{
    public class RESTListView
    {
        private readonly string URL = "http://127.0.0.1/apirestproducto/post.php";

        public async Task<HttpResponseMessage> GetProductos()
        {
            var client = new HttpClient();
            var response = await client.GetAsync(URL);
            return response;
        }

    }
}
