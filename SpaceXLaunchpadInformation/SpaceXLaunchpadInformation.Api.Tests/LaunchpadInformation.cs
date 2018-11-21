using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace SpaceXLaunchpadInformation.Api.Tests
{
    public class LaunchpadInformation
    {

        private readonly TestServer server;
        private readonly HttpClient client;

        public LaunchpadInformation()
        {
            var webHostBuilder = new WebHostBuilder()
                .UseStartup<Startup>()
                 .ConfigureAppConfiguration((context, config) =>
                 {
                     var builtConfig = config.Build();
                 }); 

            server = new TestServer(webHostBuilder);

            client = server.CreateClient();
        }

        [Fact]
        public async Task LaunchPadInformation_CallGet_ReturnsRelevantResult()
        {
            await GetLaunchpadInformation();
        }

        private async Task GetLaunchpadInformation()
        {
            string result = await client.GetStringAsync("/api/LaunchpadInformation/");
        }
    }
}
