using System;
using System.Collections.Generic;
using System.Text;

namespace RaceWorkshop.Logic.Classes
{
    public class RaceDisciplineContainer
    {
        public List<RaceDiscipline> RaceDisciplines { get; private set; }

        public RaceDisciplineContainer()
        {
            RaceDisciplines = new List<RaceDiscipline>();
        }

        public RaceDiscipline CreateRaceDiscipline(string name, int since)
        {
            return new RaceDiscipline(name, since);
        }

        public void AddRacediscipline(RaceDiscipline raceDiscipline)
        {
            RaceDisciplines.Add(raceDiscipline);
        }

        public void RemoveRaceDiscipline(RaceDiscipline raceDiscipline)
        {
            RaceDisciplines.Remove(raceDiscipline);
        }
    }
}
