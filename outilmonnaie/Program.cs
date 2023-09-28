using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace outilmonnaie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("entrez le montant a convertir");
            double montant = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ce montant est t'il en us ou en can");
            string type = Console.ReadLine();
            if (type == "us")
            {
                double dollus = montant * 1.3496;
                Console.WriteLine(montant + " dollards can donne" + dollus + "en dollards us");
            }
            else 
            {
                double dollcan = montant / 1.3496;
                Console.WriteLine(montant + " dollards us donne" + dollcan + "en dollards can");
            }
            Console.ReadKey();
        }       
    }
}
