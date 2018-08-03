using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegate
{

    //delegate void Operation(int a, int b);


    class Program
    {
        static void Main(string[] args)
        {
            // subscription
            //Operation deleguer1 = CalculUtils.Add;

            Action<int,int> deleguer1 = CalculUtils.Add;

            // subscription
            deleguer1 += CalculUtils.Mul;


            //Anonymos delagate ( 2005 c# ) 
            //deleguer1 += delegate (int a, int b)
            //{
            //    Console.WriteLine($"La somme de {a} et {b} égale à : {a + b}");
            //};


            //Expression lambda 
            deleguer1 += (a, b) =>
            {
                Console.WriteLine($"La somme de {a} et {b} égale à : {a + b}");
            };

            //Notification
            deleguer1(11, 22);



        }


    }
}
