using System;
using System.Collections;
using System.Linq;


namespace Prova
{
 //scrivere una lista di eroi in cui sono presenti dei punteggi e di cui tramite query venga richiesto di estrarne qualcuno e di cui si calcoli la media punteggio


        class Program
        {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            Hero ironman = new Hero { name = "ironman", power = "tecnology", scores = new int[] { 22, 3, 45, 67, 80, 89 } };
            Hero vedovanera = new Hero { name = "vedova nera", power = "force", scores = new int[] { 22, 44, 56, 78, 90 } };

            list.Add(ironman);
            list.Add(vedovanera);

            var read = ironman.ToString();
            ironman.ReadScores();
            Console.WriteLine(read);

            // insert directy a new hero
            list.Add(
                new Hero { name = "flash", power = "velocity", scores = new int[] { 22, 34, 12, 2 } }
                );

            // Insert in index 2 a new hero 
            list.Insert(2, new Hero { name = "thor", power = "demigod" , scores = new int[] { 22, 33, 5, 80 }});

            var query = from Hero hero in list
                        where hero.name == "thor"
                        select hero;

            Console.WriteLine("L'eroe selezionato è:");

            foreach (Hero h in query)
                Console.WriteLine(h.name + ": " + h.scores.Average());
                Console.ReadKey();

            }
        }
}

