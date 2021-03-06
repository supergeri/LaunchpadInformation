﻿using SpaceXLaunchpadInformation.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SpaceXLaunchpadInformation.Application.Repositories
{
    public interface IReadLaunchpadInformationRepository
    {
        Task<List<SpaceXLaunchpadInformation.Domain.LaunchpadInformation>> Get();
    }
}
