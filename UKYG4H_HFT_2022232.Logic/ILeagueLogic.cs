using System.Collections.Generic;
using UKYG4H_HFT_2022232.Models;

namespace UKYG4H_HFT_2022232.Logic
{
    public interface ILeagueLogic
    {
        void Create(League item);
        void Delete(int id);
        League Read(int id);
        IEnumerable<League> ReadAll();
        void Update(League item);
    }
}