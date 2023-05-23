using System;
using System.Linq;
using UKYG4H_HFT_2022232.Client;
using UKYG4H_HFT_2022232.Repository; //törlendő
using UKYG4H_HFT_2022232.Models;

namespace UKYG4H_HFT_2022232.Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FootballDbContext ctx = new FootballDbContext();
            
            //var players = ctx.Players.ToArray();
            //Valamiért törölve marad amit itt kitöröltem tesztelésnél
            
        }
    }
}
