using Moq;
using System;
using UKYG4H_HFT_2022232.Logic;
using UKYG4H_HFT_2022232.Models;
using UKYG4H_HFT_2022232.Repository;
using NUnit;
using NUnit.Framework;

namespace UKYG4H_HFT_2022232.Test
{
    [TestFixture]
    public class Tester
    {
        TeamLogic tl;
        Mock<IRepository<Team>> mockTeamRepository;
    }
}
