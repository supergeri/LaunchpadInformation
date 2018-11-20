using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceXLaunchpadInformation.Infrastructure.ApiDataAccess.Entities
{
    public class Location
    {
        public string name { get; set; }
        public string region { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
    }

    public class LaunchData
    {
        public int padid { get; set; }
        public string id { get; set; }
        public string full_name { get; set; }
        public string status { get; set; }
        public Location location { get; set; }
        public List<string> vehicles_launched { get; set; }
        public int attempted_launches { get; set; }
        public int successful_launches { get; set; }
        public string wikipedia { get; set; }
        public string details { get; set; }
    }
}
