using System.Collections.Generic;
using Newtonsoft.Json;

namespace ListagemLivros.Api.Model
{
    public class Specifications
    {
        [JsonProperty("Originallypublished")]
        public string Originallypublished { get; set; }
        
        [JsonProperty("Author")]
        public string Author { get; set; }

        [JsonProperty("Pagecount")]
        public int Pagecount { get; set; }

        [JsonProperty("Illustrator")]
        public List<string> Illustrator { get; set; }

        [JsonProperty("Genres")]
        public List<string> Genres { get; set; }

    }
}
