using NUnit.Framework;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UKYG4H_HFT_2022232.Logic;
using UKYG4H_HFT_2022232.Models;
using UKYG4H_HFT_2022232.Repository;

namespace UKYG4H_HFT_2022232.Test
{
    [TestFixture]
    internal class YouthTester
    {
        TeamLogic tl;
        LeagueLogic ll;
        PlayerLogic pl;
        Mock<IRepository<Team>> mockTeamRepository;
        Mock<IRepository<League>> mockLeagueRepository;
        Mock<IRepository<Player>> mockPlayerRepository;
        YouthSquadInfo ysi;

        [SetUp]
        public void Init()
        {
            mockTeamRepository = new Mock<IRepository<Team>>();
            mockLeagueRepository = new Mock<IRepository<League>>();
            mockPlayerRepository = new Mock<IRepository<Player>>();
            mockTeamRepository.Setup(t => t.ReadAll()).Returns(new List<Team>()
            {
                new Team(10,"FC A",1,false),
                new Team(11,"FC B",1,true),
                new Team(12,"FC C",1,false),
                new Team(11,"SC Bp",2,true),
            }.AsQueryable());
            mockLeagueRepository.Setup(t => t.ReadAll()).Returns(new List<League>()
            {
                new League(1,"Great League","England",false),
                new League(2,"Worst League 2","England",true),
            }.AsQueryable());
            mockPlayerRepository.Setup(t => t.ReadAll()).Returns(new List<Player>()
            {
                new Player(8,"Lajos",17,false,45000,"Midfilder",10),
                new Player(9,"Béla",22,false,45000,"Midfilder",10),
                new Player(10,"Krisztián",15,true,55000,"Midfilder",10)
            }.AsQueryable());
            tl = new TeamLogic(mockTeamRepository.Object);
            ll = new LeagueLogic(mockLeagueRepository.Object);
            pl = new PlayerLogic(mockPlayerRepository.Object);
            ysi = new YouthSquadInfo("Great League", 1);
        }
        [Test]
        public void YouthSquadsInLeagueTestCorrect()
        {
            Assert.AreEqual(ysi.YouthSquadsInLeague, 1);
        }
        [Test]
        public void YouthSquadsInLeagueTestWrong()
        {
            Assert.AreNotEqual(ysi.YouthSquadsInLeague, 3);
        }
        [Test]
        public void YouthSquadsFantasyNameTest()
        {
            Assert.AreEqual(ysi.Name, "Great League");
        }
    }
}
