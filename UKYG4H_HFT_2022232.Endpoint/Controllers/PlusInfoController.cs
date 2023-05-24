using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using UKYG4H_HFT_2022232.Logic;
using UKYG4H_HFT_2022232.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UKYG4H_HFT_2022232.Endpoint.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class PlusInfoController : ControllerBase
    {
        IPlayerLogic ipl;
        ITeamLogic itl;
        public PlusInfoController(IPlayerLogic ipl, ITeamLogic itl)
        {
            this.ipl = ipl;
            this.itl = itl; 
        }
        [HttpGet("{age}")]
        public IEnumerable<Player> GetPlayersYoungerThanX(int age)
        {
            return this.ipl.GetPlayersYoungerThanX(age);
        }
        [HttpGet]
        public int GetYoungsterSalaryInfo()
        {
            return this.ipl.GetYounsterSalaryInfo();
        }
        [HttpGet]
        public int GetYoungestPlayerAge()
        {
            return this.ipl.GetYoungestPlayerAge();
        }
        [HttpGet("{tsId}")]
        public double AverageSalary(int tsId)
        {
            return this.itl.GetAverageSalaryInTeam(tsId);
        }

    }
}
