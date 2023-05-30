using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UKYG4H_HFT_2022232.Logic;
using UKYG4H_HFT_2022232.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UKYG4H_HFT_2022232.Endpoint.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class YouthSquadInfoController : ControllerBase
    {
        ILeagueLogic ill;

        public YouthSquadInfoController(ILeagueLogic ill)
        {
            this.ill = ill;
        }

        // GET: api/<YouthSquadInfoController>
        [HttpGet]
        public IEnumerable<YouthSquadInfo> GetYSI()
        {
            return ill.GetYouthSquadInfo();
        }
    }
}
