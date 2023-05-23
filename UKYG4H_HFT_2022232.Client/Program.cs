using ConsoleTools;
using System;
using System.Collections.Generic;
using System.Linq;
using UKYG4H_HFT_2022232.Client;
using UKYG4H_HFT_2022232.Models;

namespace UKYG4H_HFT_2022232.Client
{
    internal class Program
    {
        static RestService rest;


        static void Create(string entity)
        {
            if (entity == "League")
            {
                Console.Write("League name: ");
                string name = Console.ReadLine();
                Console.Write("League country: ");
                string country = Console.ReadLine();
                Console.Write("League has VAR?(true/false): ");
                bool hasVar = bool.Parse(Console.ReadLine());
                rest.Post(new League() { FantasyName = name, Country = country, HasVAR = hasVar },"league");

            }
            if (entity == "Player")
            {
                Console.Write("Player name: ");
                string name = Console.ReadLine();
                Console.Write("Player age: ");
                int age = int.Parse(Console.ReadLine());
                Console.Write("Player position: ");
                string pos = Console.ReadLine();
                Console.Write("Is player right footed?(true/false): ");
                bool rf = bool.Parse(Console.ReadLine());
                Console.Write("Player salary: ");
                int sal = int.Parse(Console.ReadLine());
                Console.Write("Player team ID: ");
                int tid = int.Parse(Console.ReadLine());
                rest.Post(new Player() { Name = name, Age = age, Position= pos, RightFooted=rf, Salary=sal, TeamId = tid}, "player");
            }
            if (entity == "Team")
            {

            }
            Console.ReadLine();
        }
        static void List(string entity)
        {
            if (entity == "League")
            {
                List<League> leagues = rest.Get<League>("league");
                foreach (var item in leagues)
                {
                    Console.WriteLine("(" +item.Id +")" + item.FantasyName);
                }
            }
            if (entity == "Player")
            {
                List<Player> leagues = rest.Get<Player>("player");
                foreach (var item in leagues)
                {
                    Console.WriteLine(item.Name);
                }
            }
            if (entity == "Team")
            {
                List<Team> leagues = rest.Get<Team>("team");
                foreach (var item in leagues)
                {
                    Console.WriteLine(item.Name);
                }
            }
            Console.ReadLine();
        }
        static void Update(string entity)
        {
            Console.WriteLine(entity + " update");
            Console.ReadLine();
        }
        static void Delete(string entity)
        {
            Console.WriteLine(entity + " delete");
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            rest = new RestService("http://localhost:43006/", "league");
            var leagueSubMenu = new ConsoleMenu(args, level: 1)
                .Add("List", () => List("League"))
                .Add("Create", () => Create("League"))
                .Add("Delete", () => Delete("League"))
                .Add("Update", () => Update("League"))
                .Add("Exit", ConsoleMenu.Close);

            var teamSubMenu = new ConsoleMenu(args, level: 1)
                .Add("List", () => List("Team"))
                .Add("Create", () => Create("Team"))
                .Add("Delete", () => Delete("Team"))
                .Add("Update", () => Update("Team"))
                .Add("Exit", ConsoleMenu.Close);

            var playerSubMenu = new ConsoleMenu(args, level: 1)
                .Add("List", () => List("Player"))
                .Add("Create", () => Create("Player"))
                .Add("Delete", () => Delete("Player"))
                .Add("Update", () => Update("Player"))
                .Add("Exit", ConsoleMenu.Close);
            var menu = new ConsoleMenu(args, level: 0)
                .Add("Leagues", () => leagueSubMenu.Show())
                .Add("Teams", () => teamSubMenu.Show())
                .Add("Players", () => playerSubMenu.Show())
                .Add("Exit", ConsoleMenu.Close);

            menu.Show();

        }
    }
}
