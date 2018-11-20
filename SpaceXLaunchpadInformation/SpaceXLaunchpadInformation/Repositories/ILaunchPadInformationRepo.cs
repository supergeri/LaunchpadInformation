using SpaceXLaunchpadInformation.ServiceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceXLaunchpadInformation.Repositories
{
    public interface ILaunchPadInformationRepo
    {
        LaunchPadInformation GetLaunchPadInformation();
    }
}
