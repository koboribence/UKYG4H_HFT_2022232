using System;
using System.Linq;
using UKYG4H_HFT_2022232.Client;
using UKYG4H_HFT_2022232.Repository; //törlendő

namespace UKYG4H_HFT_2022232.Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FootballDbContext ctx = new FootballDbContext();
            var leagues = ctx.Leagues.ToArray();
            var teams = ctx.Teams.ToArray();
            var players = ctx.Players.ToArray();
            ;
        }
    }
}
