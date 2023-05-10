using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UKYG4H_HFT_2022232.Models;

namespace UKYG4H_HFT_2022232.Repository
{
    public class LeagueRepository : ILeagueRepository
    {
        FootballDbContext context;
        public LeagueRepository(FootballDbContext context )
        {
            this.context = context; 
        }
        public void Create(League league)
        {
            this.context.Leagues.Add(league);
            this.context.SaveChanges();
        }
        public void Delete (int id)
        {
            this.context.Leagues.Remove(Read(id));
            this.context.SaveChanges();
        }
        public League Read(int id)
        {
            return this.context.Leagues.FirstOrDefault(t => t.Id == id);    //null-al térünk vissza, Logic-ban kezeljük majd
        }
        public IQueryable<League> ReadAll()
        {
            return this.context.Leagues;
        }
        public void Update(League league) 
        {
            var oldleague = Read(league.Id);
            oldleague.FantasyName = league.FantasyName;
            oldleague.Country = league.Country;
            oldleague.HasVAR = league.HasVAR;
            this.context.SaveChanges();
        }
    }
}
