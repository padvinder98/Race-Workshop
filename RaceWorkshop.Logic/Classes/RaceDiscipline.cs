using System;
using System.Collections.Generic;
using System.Text;

namespace RaceWorkshop.Logic.Classes
{
    public class RaceDiscipline
    {
        public string Name { get; private set; }
        public int Since { get; private set; }
        public bool Active { get; private set; } = false;
        public List<Season> Seasons { get; private set; }

        public RaceDiscipline(string name, int since)
        {
            Name = name;
            Since = since;
            Seasons = new List<Season>();
        }

        public Season CreateSeason(int numberOfRaces, int year)
        {
            return new Season(numberOfRaces, year);
        }

        public void AddSeason(Season season)
        {
            Seasons.Add(season);
        }

        public void RemoveSeason(Season season)
        {
            Seasons.Remove(season);
        }

        public void UpdateRaceDiscipline(string name, int since, bool active)
        {
            Name = name;
            Since = since;
            Active = active;
        }
    }
}
