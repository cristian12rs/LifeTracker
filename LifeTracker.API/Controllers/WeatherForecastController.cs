using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LifeTracker.API.Controllers
{
    [ApiController]
    [Route("[Music]")]
    public class WeatherForecastController : ControllerBase
    {
        
        [HttpGet]
        public Task<object> GetMusicStatistics()
        {
            return null;
        }
    }
}
