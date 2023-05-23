using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Data;
using Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;


namespace DataAccess
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DatabaseDataRetriever dataRetriever = new DatabaseDataRetriever();
            User user = new User();
            user.Name = "Nicola3";
            user.Username = "Nicola03";
            user.Password = "password";
            User user1 = dataRetriever.RegisterUser(user).Result;
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}