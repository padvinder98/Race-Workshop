using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace RaceWorkshop.Logic.Classes
{
    public class Season
    {
        public int NumberOfRaces { get; private set; }
        public string Champion { get; private set; } = null;
        public int Year { get; private set; }

        public Season(int numberOfRaces, int year)
        {
            NumberOfRaces = numberOfRaces;
            Year = year;
        }
    }
}
