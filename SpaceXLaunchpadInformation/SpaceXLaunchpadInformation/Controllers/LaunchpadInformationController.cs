using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaceXLaunchpadInformation.Application.LaunchpadInformation.Queries.GetLaunchpadInformation;

namespace SpaceXLaunchpadInformation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LaunchpadInformationController : ControllerBase
    {
        private IGetLaunchpadInformation _launchPadInformationQuery;

        public LaunchpadInformationController(IGetLaunchpadInformation launchPadInformationQuery)
        {
            _launchPadInformationQuery = launchPadInformationQuery;
        }

        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var launchPadInfoModel = await _launchPadInformationQuery.Execute();

            return Ok(launchPadInfoModel);
        }

    }
}
