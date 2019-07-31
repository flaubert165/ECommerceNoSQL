using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace ECommerceNoSQL.Rest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Apache.Ignite.Core.Ignition.Start();
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
