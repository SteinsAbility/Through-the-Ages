using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets
{
    class Card : MonoBehaviour
    {
        public string cardName = "";
        public int cardAge = 0;

        public Card(String name, int age)
        {
            cardName = name;
            cardAge = age;
        }
    }
}
