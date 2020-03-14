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
                case "nwday":
                    var day = DateTime.Today.DayOfWeek;
                    switch(day)
                    {
                        case DayOfWeek.Monday:
                            ret = "1";
                            break;
                        case DayOfWeek.Tuesday:
                            ret = "2";
                            break;
                        case DayOfWeek.Wednesday:
                            ret = "3";
                            break;
                        case DayOfWeek.Thursday:
                            ret = "4";
                            break;
                        case DayOfWeek.Friday:
                            ret = "5";
                            break;
                        case DayOfWeek.Saturday:
                            ret = "6";
                            break;
                        default:
                            ret = "7";
                            break;
                    }
                    break;
                default:
                    break;
            }
            return new time() { r=ret};
        }
    }
}