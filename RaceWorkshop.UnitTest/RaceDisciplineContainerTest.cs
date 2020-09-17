using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RaceWorkshop.Logic.Classes;

namespace RaceWorkshop.UnitTest
{
    [TestClass]
    public class RaceDisciplineContainerTest
    {
        [TestMethod]
        public void RaceDisciplineContainer_CreateRaceDiscipline()
        {
            // Arrange
            RaceDisciplineContainer raceDisciplineContainer = new RaceDisciplineContainer();

            string name = "Formula 1";
            int since = 1980;

            // Act
            RaceDiscipline raceDiscipline = raceDisciplineContainer.CreateRaceDiscipline(name, since);

            // Assert
            raceDiscipline.Name.Should().Be(name);
            raceDiscipline.Since.Should().Be(since);
            raceDiscipline.Active.Should().BeFalse();
        }

        [TestMethod]
        public void RaceDisciplineContainer_AddRaceDiscipline()
        {
            // Arrange
            RaceDisciplineContainer raceDisciplineContainer = new RaceDisciplineContainer();

            string name = "Formula 1";
            int since = 1980;

            RaceDiscipline raceDiscipline = raceDisciplineContainer.CreateRaceDiscipline(name, since);

            // Act
            raceDisciplineContainer.AddRacediscipline(raceDiscipline);

            // Assert
            raceDisciplineContainer.RaceDisciplines.Should().Contain(raceDiscipline);
        }

        [TestMethod]
        public void RaceDisciplineContainer_RemoveRaceDiscipline()
        {
            // Arrange
            RaceDisciplineContainer raceDisciplineContainer = new RaceDisciplineContainer();

            string name = "Formula 1";
            int since = 1980;

            RaceDiscipline raceDiscipline = raceDisciplineContainer.CreateRaceDiscipline(name, since);

            raceDisciplineContainer.AddRacediscipline(raceDiscipline);

            // Act
            raceDisciplineContainer.RemoveRaceDiscipline(raceDiscipline);

            // Assert
            raceDisciplineContainer.RaceDisciplines.Should().NotContain(raceDiscipline);
        }
    }
}
