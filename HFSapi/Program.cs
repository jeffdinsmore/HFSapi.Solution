﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace HFSapi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseUrls("http://localhost:5003"); //Added to enable Token
    }
}
