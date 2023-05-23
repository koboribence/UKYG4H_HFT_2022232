using System.Collections.Generic;
using UKYG4H_HFT_2022232.Models;

namespace UKYG4H_HFT_2022232.Logic
{
    public interface ITeamLogic
    {
        void Create(Team item);
        void Delete(int id);
        IEnumerable<YouthSquadInfo> GetYouthSquadInfo();
        Team Read(int id);
        IEnumerable<Team> ReadAll();
        void Update(Team item);
    }
}