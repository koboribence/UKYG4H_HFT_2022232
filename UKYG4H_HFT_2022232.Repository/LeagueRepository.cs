using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UKYG4H_HFT_2022232.Models;

namespace UKYG4H_HFT_2022232.Repository
{
    public class LeagueRepository : Repository<League>, IRepository<League>
    {
        public LeagueRepository(FootballDbContext ctx): base(ctx) 
        { 

        }
        public override League Read(int id)
        {
            return this.ctx.Leagues.First(t=> t.Id == id);  
        }
        public override void Update(League item)
        {
            var old  = Read(item.Id);
            foreach (var p in old.GetType().GetProperties())
            {
                if(p.GetAccessors().FirstOrDefault(t=> t.IsVirtual) ==null)
                {
                    p.SetValue(old, p.GetValue(item));
                }
            }
            ctx.SaveChanges();
        }

    }
}
