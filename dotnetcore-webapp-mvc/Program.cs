﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace dotnetcore_webapp_mvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .ConfigureKestrel((context, options) =>
            {
                options.Limits.MaxConcurrentConnections = null;
                //options.Limits.MaxConcurrentUpgradedConnections = 100;
               // options.Limits.MaxRequestBodySize = 10 * 1024;
               // options.Limits.MinRequestBodyDataRate =
                 //   new MinDataRate(bytesPerSecond: 100, gracePeriod: TimeSpan.FromSeconds(10));
               // options.Limits.MinResponseDataRate =
                  //  new MinDataRate(bytesPerSecond: 100, gracePeriod: TimeSpan.FromSeconds(10));
                //options.Listen(IPAddress.Loopback, 5000);
                //options.Listen(IPAddress.Loopback, 5001, listenOptions =>
               // {
                    //listenOptions.UseHttps("testCert.pfx", "testPassword");
               // });
            })
            .UseStartup<Startup>();
    }
}
