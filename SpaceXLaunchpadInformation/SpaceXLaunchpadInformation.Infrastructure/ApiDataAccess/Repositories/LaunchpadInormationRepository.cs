using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SpaceXLaunchpadInformation.Application.Repositories;
using SpaceXLaunchpadInformation.Domain;
using SpaceXLaunchpadInformation.Infrastructure.ApiDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SpaceXLaunchpadInformation.Infrastructure.ApiDataAccess.Repositories
{
    public class LaunchpadInormationRepository : IReadLaunchpadInformationRepository
    {


        public async Task<List<LaunchpadInformation>> Get()
        {
            using (var client = new HttpClient())
            {
      
                var response = client.GetStringAsync(new Uri("https://api.spacexdata.com/v2/launchpads")).Result;
                var data  = JsonConvert.DeserializeObject< List<LaunchData>>(response);

                var result = new List<LaunchpadInformation>();

                data.ForEach(x =>
                {
                    result.Add(new LaunchpadInformation
                    {
                        LaunchPadId = x.id,
                        LaunchPadName = x.full_name,
                        LaunchPadStatus = x.status,
                    });
                });

                return result;
            }
        }
    }
}
