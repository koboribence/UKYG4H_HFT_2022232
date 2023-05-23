using System;
using System.Linq;
using UKYG4H_HFT_2022232.Client;
using UKYG4H_HFT_2022232.Repository; //törlendő
using UKYG4H_HFT_2022232.Models;
using UKYG4H_HFT_2022232.Logic;

namespace UKYG4H_HFT_2022232.Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FootballDbContext ctx = new FootballDbContext();
            var repo = new PlayerRepository(ctx);
            var logic = new PlayerLogic(repo);
            var items = logic.ReadAll();
            //var players = ctx.Players.ToArray();
            //Valamiért törölve marad amit itt kitöröltem tesztelésnél
            
        }
    }
}
