using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceXLaunchpadInformation.ServiceModels
{
    public class LaunchPadInformation
    {
        public int LaunchPadId { get; set; }

        public string LaunchPadName { get; set; }

        public int LaunchPadStatus { get; set; }
    }
}
