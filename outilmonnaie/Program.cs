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
            Console.WriteLine("ce montant est t'il en us, en can ou en euro");
            string type = Console.ReadLine();
            Console.WriteLine("En quoi voulez vous convertir votre montant");
            string type2 = Console.ReadLine();
            if (type == "can" && type2 == "us")
            {
                double dollus = montant * 1.3496;
                Console.WriteLine(montant + " dollards can donne" + dollus + "en dollards us");
            }
            if (type == "can" && type2 == "euro")
            {
                double dolleu = montant * 1.42;
                Console.WriteLine(montant + " dollards can donne" + dolleu + "en dollards euro");
            }
            if (type == "us" && type2 == "euro")
            {
                double dolleu = montant * 0.95;
                Console.WriteLine(montant + " dollards us donne" + dolleu + "en dollards euro");
            }
            if (type == "us" && type2 == "can")
            {
                double dollca = montant / 1.3496;
                Console.WriteLine(montant + " dollards us donne" + dollca + "en dollards can");
            }
            if (type == "euro" && type2 == "us")
            {
                double dollus = montant / 0.95;
                Console.WriteLine(montant + " dollards can donne" + dollus + "en dollards euro");
            }
            if (type == "euro" && type2 == "can")
            {
                double dollca = montant / 1.42;
                Console.WriteLine(montant + " dollards can donne" + dollca + "en dollards euro");
            }
            Console.ReadKey();
        }       
    }
}
