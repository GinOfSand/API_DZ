using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace API_DZ
{
    internal class ApiNumbers : ApiServic
    {
        public string res { get; set; }
        public async void Zapros(int numbers)
        {
            NumbersFact fact = new NumbersFact();
            HttpClient client = new HttpClient();
            fact = await client.GetFromJsonAsync<NumbersFact>("http://numbersapi.com/" + $"{numbers}" + "/math?json");
            res = fact.text;


        }
    }
}
