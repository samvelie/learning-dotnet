using System;
using Microsoft.AspNetCore.Hosting;
using becomingwebby;

namespace hwapp
{
    class Program
    {
        static void Main(string[] args)
        {   
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>()
                .Build();
            
            host.Run();
        }
    }
}
