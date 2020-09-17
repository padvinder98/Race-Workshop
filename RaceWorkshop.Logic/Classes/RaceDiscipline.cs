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

        public RaceDiscipline(string name, int since)
        {
            Name = name;
            Since = since;
        }
    }
}
