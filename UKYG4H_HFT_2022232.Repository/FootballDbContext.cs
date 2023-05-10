using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Drawing;
using UKYG4H_HFT_2022232.Models;

namespace UKYG4H_HFT_2022232.Repository
{
    public class FootballDbContext : DbContext
    {
        public DbSet<League> Leagues { get; set; }
        public DbSet<Team> Teams { get; set; }  
        public DbSet<Player> Players { get; set; }
        public FootballDbContext()
        {
            this.Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\kobor\source\repos\UKYG4H_HFT_2022232\UKYG4H_HFT_2022232.Repository\FootballLeagues.mdf; Integrated Security = True");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>()
                .HasOne(x => x.League)
                .WithMany(x => x.Teams)
                .HasForeignKey(t => t.LeagueId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Player>()
                .HasOne(x => x.Team)
                .WithMany(x => x.Players)
                .HasForeignKey(x => x.TeamId)
                .OnDelete(DeleteBehavior.Cascade);
            base.OnModelCreating(modelBuilder);
            var leagues = new List<League>()
            {
                new League(){Id= 1, FantasyName = "OTP Bank Liga", Country = "Hungary", HasVAR=true},
                //new League(){Id = 2, FantasyName = "Ekstraklasa", Country = "Poland", HasVAR = false },
                //new League(){Id= 3, FantasyName = "LaLiga", Country = "Spain", HasVAR=true}
            };
            modelBuilder.Entity<League>().HasData(leagues);

            var teams = new List<Team>()
            {
                new Team(){Id=1, LeagueId = 1, Name = "Ferencvárosi TC"},
                new Team(){Id=2, LeagueId = 1, Name = "Újpesti FC"},
                //new Team(){Id=3, LeagueId = 1, Name = "Kecskeméti TE"},
                //new Team(){Id=4, LeagueId = 2, Name = "Legia Warszawa"},
                //new Team(){Id=5, LeagueId = 2, Name = "Lech Poznan"},
                //new Team(){Id=6, LeagueId = 2, Name = "Cracovia"},
                //new Team(){Id=7, LeagueId = 3, Name = "FC Barcelona"},
                //new Team(){Id=8, LeagueId = 3, Name = "Real Madrid CF"},
                //new Team(){Id=9, LeagueId = 3, Name = "Valencia CF"},
            };
            modelBuilder.Entity<Team>().HasData(teams);
            var players = new List<Player>()
            {
                new Player(){Id=1, Name = "Lisztes Krisztián", Age = 18, Position = "Midfilder", Salary = 1200000, TeamId =1},
                new Player(){Id=2, Name = "Adama Traoré", Age = 27, Position = "Striker", Salary = 2500000, TeamId =1},
                new Player(){Id=3, Name = "Auzqui Carlos Daniel", Age = 32, Position = "Defender", Salary = 1550000, TeamId =1},
                new Player(){Id=4, Name = "Simon Krisztián", Age = 31, Position = "Midfilder", Salary = 1000000, TeamId =2},
                new Player(){Id=5, Name = "Csoboth Kevin", Age = 22, Position = "Striker", Salary = 1100000, TeamId =2},
                new Player(){Id=6, Name = "Bjelos Miroslav", Age = 32, Position = "Defender", Salary = 1800000, TeamId =2},
            };
            modelBuilder.Entity<Player>().HasData(players);
        }
    }
}
