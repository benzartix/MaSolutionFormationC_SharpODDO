using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegate
{
    class CalculUtils
    {

        internal static void Add(int a, int b)
        {
            //string interpolation avec le $
            Console.WriteLine($"La somme de {a} et {b} égale à : {a + b}");
            //Console.WriteLine($"La somme de  "+ a +" et "+ b +" égale à : "+ a + b);
        }

        internal static void Mul(int a, int b)
        {
            Console.WriteLine($"La somme de {a} et {b} égale à : {a * b}");
            //Console.WriteLine($"La somme de  "+ a +" et "+ b +" égale à : "+ a + b);
        }


    }
}
