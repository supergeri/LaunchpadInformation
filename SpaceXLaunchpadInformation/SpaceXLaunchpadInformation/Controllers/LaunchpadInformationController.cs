using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaceXLaunchpadInformation.Repositories;

namespace SpaceXLaunchpadInformation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LaunchpadInformationController : ControllerBase
    {
        private ILaunchPadInformationRepo _launchPadInformationRepo;

        public LaunchpadInformationController(ILaunchPadInformationRepo launchPadInformationRepo)
        {
            _launchPadInformationRepo = launchPadInformationRepo;
        }

        // GET api/values
        [HttpGet]
        public IActionResult GetLaunchPadInformation()
        {
            var launchPadInfoModel = _launchPadInformationRepo.GetLaunchPadInformation();

            return Ok(launchPadInfoModel);
        }

    }
}
