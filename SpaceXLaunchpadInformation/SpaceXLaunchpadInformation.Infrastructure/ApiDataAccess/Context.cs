using SpaceXLaunchpadInformation.Domain;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace SpaceXLaunchpadInformation.Infrastructure.ApiDataAccess
{
    public class Context
    {
        public LaunchpadInformation launchpadInformation { get; set; }
        public readonly HttpClient httpClient;

        public Context()
        {
            launchpadInformation = new LaunchpadInformation();
            httpClient = new HttpClient();
        }
    }
}
