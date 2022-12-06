using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plesoczki_Á_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, db;
            Console.WriteLine("hány nevet tartalmaz a lista ");
            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());
            String[] nev = new string[n];
            db = 0;
            for ( i = 0; i < n; i++) ;
            {
                Console.Write("{0}.név: ", i + 1);
                nev[i] = Console.ReadLine();
            }
            Console.WriteLine("\n\nMelyik nevet keressem meg");
            string ker_nev = Console.ReadLine();
            for (i = 0; i < n; i++)
            {
                if (nev[i] == ker_nev)
                    db++;

            }
            Console.WriteLine("{0} -szor szerepel a{1} név.", db, ker_nev);
            Console.ReadLine();

        }
    }
}
