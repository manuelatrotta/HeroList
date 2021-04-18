using System;
using System.Collections.Generic;
using System.Text;

namespace Prova
{
    class Hero
    {
        public string name { get; set; }
        public string power { get; set; }
        public int[] scores { get; set; }


        public void ReadScores()
        {
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine(scores[i]);
            }
        }


        public string ToString() => "Hero: " + name + " " + power ;
    }
}
