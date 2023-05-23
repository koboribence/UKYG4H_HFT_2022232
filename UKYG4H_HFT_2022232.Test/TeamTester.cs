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
    public class TeamTester
    {
        TeamLogic tl;
        Mock<IRepository<Team>> mockTeamRepository;

        [SetUp]
        public void Init()
        {
            mockTeamRepository = new Mock<IRepository<Team>>();
            mockTeamRepository.Setup(t => t.ReadAll()).Returns(new List<Team>()
            {
                new Team(10,"FC A",1,false),
                new Team(11,"FC B",1,true),
                new Team(12,"FC C",1,false),
            }.AsQueryable());
            tl = new TeamLogic(mockTeamRepository.Object);
        }
        [Test]
        public void CreateTest()
        {
            var t = new Team(13, "FC D", 1, true);
            tl.Create(t);
            mockTeamRepository.Verify(a=> a.Create(t),Times.Once());
        }
        public void UpdateTest()
        {
        }
    }
}
