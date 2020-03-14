using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KDPdate.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class timeController : ControllerBase
    {
        [HttpGet("{func}")]
        public time onGet(string func)
        {
            string ret = string.Empty;
            switch(func)
            {
                case "nday":
                    ret = DateTime.Today.Day.ToString();
                    break;
                case "nmonth":
                    ret = DateTime.Today.Month.ToString();
                    break;
                case "nyear":
                    ret = DateTime.Today.Year.ToString();
                    break;
                case "day":
                    ret = DateTime.Today.DayOfWeek.ToString();
                    break;
                default:
                    break;
            }
            return new time() { r=ret};
        }
    }
}