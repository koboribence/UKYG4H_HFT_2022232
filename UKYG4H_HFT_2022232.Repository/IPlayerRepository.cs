using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UKYG4H_HFT_2022232.Models;

namespace UKYG4H_HFT_2022232.Repository
{
    internal interface IPlayerRepository
    {
        void Create(Player player);
        Player Read(int id);
        IQueryable<Player> ReadAll();
        void Update(Player player);
        void Delete(int id);
    }
}
