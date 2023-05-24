using System.Collections.Generic;
using UKYG4H_HFT_2022232.Models;

namespace UKYG4H_HFT_2022232.Logic
{
    public interface IPlayerLogic
    {
        void Create(Player item);
        void Delete(int id);
        IEnumerable<Player> GetPlayersYoungerThanX(int x);
        int GetYoungestPlayerAge();
        int GetYounsterSalaryInfo();
        Player Read(int id);
        IEnumerable<Player> ReadAll();
        void Update(Player item);
    }
}