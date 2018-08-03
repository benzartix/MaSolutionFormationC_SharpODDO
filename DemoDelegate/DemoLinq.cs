using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegate
{
    public class DemoLinq
    {
        static void Main(string[] args)
        {


            IEnumerable<string> participants =
                new List<string>
                { "Ahmed","zakaria","Iheb","Oussema"};


            var filtre_extention_style = participants.Where(p => p.StartsWith("A"));


            var filtre2_query_style = from p in participants where p.StartsWith("A") select p;


        }
    }
}
