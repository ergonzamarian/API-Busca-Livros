using System;
using Newtonsoft.Json;

namespace ListagemLivros.Api.Model
{
    public class Livros
    {
        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }
        
        [JsonProperty("price")]
        public double price { get; set; }

        [JsonProperty("Specifications")]
        public Specifications specifications { get; set; }

        internal object DownloadString(string v)
        {
            throw new NotImplementedException();
        }
    }
}
