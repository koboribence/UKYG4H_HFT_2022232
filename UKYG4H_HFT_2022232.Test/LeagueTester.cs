using Moq;
using System;
using UKYG4H_HFT_2022232.Logic;
using UKYG4H_HFT_2022232.Models;
using UKYG4H_HFT_2022232.Repository;
using NUnit;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace UKYG4H_HFT_2022232.Test
{
    [TestFixture]
    public class LeagueTester
    {
        LeagueLogic llog;
        Mock<IRepository<League>> mockLeagueRepository;

        [SetUp]
        public void Init()
        {
            mockLeagueRepository = new Mock<IRepository<League>>();
            mockLeagueRepository.Setup(t => t.ReadAll()).Returns(new List<League>()
            {
                new League(10,"Liga A","Hungary",true),
                new League(11,"Liga B","Hungary",true),
                new League(12,"Liga C","Hungary",false),
            }.AsQueryable());
            llog = new LeagueLogic(mockLeagueRepository.Object);
        }
        [Test]
        public void LeagueCreateTest()
        {
            var l = new League(13, " Liga", "Hungary", false);
            llog.Create(l);
            mockLeagueRepository.Verify(a => a.Create(l), Times.Once());
        }
    }
}
