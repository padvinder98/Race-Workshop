using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RaceWorkshop.Logic.Classes;

namespace RaceWorkshop.UnitTest
{
    [TestClass]
    public class RaceDisciplineTest
    {
        [TestMethod]
        public void RaceDiscipline_CreateSeason()
        {
            // Arrange
            int numberOfRaces = 20;
            int year = 2020;

            RaceDiscipline raceDiscipline = new RaceDiscipline("Formula 1", 1980);

            // Act
            Season season = raceDiscipline.CreateSeason(numberOfRaces, year);

            // Assert
            season.NumberOfRaces.Should().Be(numberOfRaces);
            season.Year.Should().Be(year);
        }
    }
}
