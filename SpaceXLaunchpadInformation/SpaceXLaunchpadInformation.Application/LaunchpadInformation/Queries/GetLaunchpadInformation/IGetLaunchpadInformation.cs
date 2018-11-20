using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SpaceXLaunchpadInformation.Application.LaunchpadInformation.Queries.GetLaunchpadInformation
{
    public interface IGetLaunchpadInformation
    {
        Task<SpaceXLaunchpadInformation.Domain.LaunchpadInformation> Execute();
    }
}
