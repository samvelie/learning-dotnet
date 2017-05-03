using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace becomingwebby
{
    class Program
    {
        static void Main(string[] args)
        {   
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseUrls("http://localhost:2020")
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();
            
            host.Run();
        }
    }
}
