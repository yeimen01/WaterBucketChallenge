using Microsoft.AspNetCore.Mvc;
using WaterBucketChallenge.Models;
using WaterBucketChallenge.Services;

namespace WaterBucketChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WaterBucketController : ControllerBase
    {
        private readonly IWaterBucketService _waterBucketService;

        public WaterBucketController(IWaterBucketService waterBucketService)
        {
            _waterBucketService = waterBucketService;
        }

        [HttpGet()]
        [Route("steps")]
        public string Steps(int x, int y, int z)
        {
            return _waterBucketService.Steps(x, y, z);
        }

        [HttpGet()]
        [Route("stepsDetail")]
        public List<Step> StepsDetail(int x, int y, int z)
        {
            return _waterBucketService.StepsDetail(x,y,z);
        }
    }
}
