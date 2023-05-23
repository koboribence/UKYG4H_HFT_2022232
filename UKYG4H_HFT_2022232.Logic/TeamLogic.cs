using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UKYG4H_HFT_2022232.Models;
using UKYG4H_HFT_2022232.Repository;

namespace UKYG4H_HFT_2022232.Logic
{
    public class TeamLogic : ITeamLogic
    {
        IRepository<Team> repository;
        public TeamLogic(IRepository<Team> repository)
        {
            this.repository = repository;
        }
        public void Create(Team item)
        {
            if (item.Id < 0)
            {
                throw new ArgumentException("The team ID cannot be negative!");
            }
            else
            {
                this.repository.Create(item);
            }
        }
        public Team Read(int id)
        {
            var p = this.repository.Read(id);
            if (p == null)
            {
                throw new ArgumentException("Team not exists!");
            }
            return p;
        }
        public void Delete(int id)
        {
            this.repository.Delete(id);
        }
        public IEnumerable<Team> ReadAll()
        {
            return this.repository.ReadAll();
        }
        public void Update(Team item)
        {
            this.repository.Update(item);
        }
        public IEnumerable<YouthSquadInfo> GetYouthSquadInfo()
        {
            return from x in this.repository.ReadAll()
                   group x by x.League.FantasyName into g
                   select new YouthSquadInfo()
                   {
                       Name = g.Key,
                       YouthSquadsInLeague = g.Count(t => t.HasYouthSquad)
                   };

        }
    }
    public class YouthSquadInfo
    {
        public YouthSquadInfo()
        {
        }
        public string Name { get; set; }
        public int YouthSquadsInLeague { get; set; }
    }
}
