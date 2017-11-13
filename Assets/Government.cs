using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets
{
    class Government : Card
    {
        public int civilactions = 0;
        public int militaryactions = 0;
        public int maxurbanworkers = 0;

        public Government(string name, int age, int CivilAct, int MiliAct, int MaxUrbWorker) : base(name, age)
        {
            civilactions = CivilAct;
            militaryactions = MiliAct;
            maxurbanworkers = MaxUrbWorker;
        }
    }
}
