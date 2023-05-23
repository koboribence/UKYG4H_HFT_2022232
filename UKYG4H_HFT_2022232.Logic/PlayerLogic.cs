using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UKYG4H_HFT_2022232.Models;
using UKYG4H_HFT_2022232.Repository;

namespace UKYG4H_HFT_2022232.Logic
{
    public class PlayerLogic
    {
        IRepository<Player> repository;
        public PlayerLogic(IRepository<Player> repository)
        {
            this.repository = repository;
        }
        public void Create(Player item)
        {
            if (item.Id < 0)
            {
                throw new ArgumentException("The player ID cannot be negative!");
            }
            else
            {
                this.repository.Create(item);
            }
        }
        public Player Read(int id)
        {
            var p = this.repository.Read(id);
            if (p == null)
            {
                throw new ArgumentException("Player not exists");
            }
            return p;
        }
        public void Delete(int id)
        {
            this.repository.Delete(id);
        }
        public IEnumerable<Player> ReadAll()
        {
            return this.repository.ReadAll();
        }
        public void Update(Player item)
        {
            this.repository.Update(item);
        }
    }
}
