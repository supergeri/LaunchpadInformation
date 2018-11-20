using Newtonsoft.Json.Linq;
using SpaceXLaunchpadInformation.Application.Repositories;
using SpaceXLaunchpadInformation.Domain;
using SpaceXLaunchpadInformation.Infrastructure.ApiDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SpaceXLaunchpadInformation.Infrastructure.ApiDataAccess.Repositories
{
    public class LaunchpadInormationRepository : IReadLaunchpadInformationRepository
    {
        private readonly string url = "https://api.spacexdata.com/v2/launchpads";

        private readonly Context _context;

        public LaunchpadInormationRepository(Context context)
        {
            _context = context;
        }

        public async Task<LaunchpadInformation> Get()
        {
            using (var client = _context.httpClient)
            {
                var response = client.GetStringAsync(new Uri(url)).Result;
                var releases = JArray.Parse(response);

                var entitiyResult =  releases.ToObject<LaunchData>();

                var result = _context.launchpadInformation;

                result.LaunchPadId = entitiyResult.id;
                result.LaunchPadName = entitiyResult.full_name;
                result.LaunchPadStatus = entitiyResult.status;

                return result;
            }
        }
    }
}
