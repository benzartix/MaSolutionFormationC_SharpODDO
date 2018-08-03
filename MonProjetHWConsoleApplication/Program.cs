using ODDO.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonProjetHWConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //cw tab tab
            System.Console.WriteLine("Bienvenue C#");

            Compte c = new Compte { Numero = "C100", Proprietaire = "ahmed", Solde = 1000M };


            Console.WriteLine(c.ToString());
        }
    }
}
