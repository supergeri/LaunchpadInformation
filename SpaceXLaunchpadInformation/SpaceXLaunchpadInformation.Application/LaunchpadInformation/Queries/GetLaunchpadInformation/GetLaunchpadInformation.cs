using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SpaceXLaunchpadInformation.Application.Repositories;
using SpaceXLaunchpadInformation.Domain;

namespace SpaceXLaunchpadInformation.Application.LaunchpadInformation.Queries.GetLaunchpadInformation
{
    public sealed class GetLaunchpadInformation : IGetLaunchpadInformation
    {
        private IReadLaunchpadInformationRepository _readLaunchpadInformationRepository;

        public GetLaunchpadInformation(IReadLaunchpadInformationRepository readLaunchpadInformationRepository)
        {
            _readLaunchpadInformationRepository = readLaunchpadInformationRepository;
        }


        public Task<Domain.LaunchpadInformation> Execute()
        {
            return _readLaunchpadInformationRepository.Get();
        }
    }
}
