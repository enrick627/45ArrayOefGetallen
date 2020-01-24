//5ITN nr3 Enrick De Munter 24/01/2020
/*OPgave
 * =====
 * Vraag 5 getallen en toon ze gesorteerd
 *
 * ANALYSE
 * =======
 * VRAAG 5 * getallen aan gebruiker
 * 
 * BEREKEN  Als gebruiker getalen heeft ingevoerd
 *          DAN  zet getalen in volgorde
 *
 * TOON     de getaal gesorteerd in volgorde
 * 
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOefGetallen
{
    class Program
    {
        static void Main(string[] args)
        {
            //variabelen
            byte[] getal = new byte[5];

            
            for (int i = 0; i < 5; i++)
            {
                // VRAAG 5 * getallen aan gebruiker
                Console.WriteLine("geef een getal");
                getal[i] = byte.Parse(Console.ReadLine());
            }
            // BEREKEN  Als gebruiker getalen heeft ingevoerd
            //          DAN  zet getalen in volgorde
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                
                Console.WriteLine(getal[i]);
            }
            // TOON     de getaal gesorteerd in volgorde

            //wachten
            Console.WriteLine();
            Console.WriteLine("druk op enter om af te sluiten");
            Console.ReadKey();
        }
    }
}
