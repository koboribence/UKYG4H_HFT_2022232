using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UKYG4H_HFT_2022232.Models;

namespace UKYG4H_HFT_2022232.Repository
{
    internal interface ILeagueRepository
    {
        void Create(League league);
        League Read(int id);
        IQueryable<League> ReadAll();
        void Update(League league);
        void Delete(int id);    
    }
}
