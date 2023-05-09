using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UKYG4H_HFT_2022232.Models;

namespace UKYG4H_HFT_2022232.Repository
{
    internal interface ITeamRepository
    {
        void Create(Team team);
        Team Read(int id);
        IQueryable<Team> ReadAll();
        void Update(Team team);
        void Delete(int id);
    }
}
