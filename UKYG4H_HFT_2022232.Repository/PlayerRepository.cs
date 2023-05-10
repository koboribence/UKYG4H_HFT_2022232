using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UKYG4H_HFT_2022232.Models;

namespace UKYG4H_HFT_2022232.Repository
{
    public class PlayerRepository : Repository<Player>, IRepository<Player>
    {
        public PlayerRepository(FootballDbContext ctx) : base(ctx)
        {

        }
        public override Player Read(int id)
        {
            return this.ctx.Players.First(t => t.Id == id);
        }
        public override void Update(Player item)
        {
            var old = Read(item.Id);
            foreach (var p in old.GetType().GetProperties())
            {
                p.SetValue(old, p.GetValue(item));
            }
            ctx.SaveChanges();
        }
    }
}
