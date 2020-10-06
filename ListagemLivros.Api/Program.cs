using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace ListagemLivros.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                CreateWebHostBuilder(args).Build().Run();
                
            }
            catch(Exception e)
            {
                 
                Console.WriteLine(e.Message);
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseUrls("http://localhost:5002")
                .UseStartup<Startup>();
    }
}
