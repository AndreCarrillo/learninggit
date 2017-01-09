using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTestApp
{

    class Program
    {

        static void Main(string[] args)
        {
            /*  Dictionary<string, string> capitals = new Dictionary<string, string>();
              capitals.Add("Alabama", "Montgomery");
              capitals.Add("Alaska", "Juneau");
              capitals.Add("Arizona", "Pheonix");
              capitals.Add("Massachusetts", "Boston");
              capitals.Add("Wyoming", "Cheyenne");
              capitals.Add("Maryland", "Annapolis");

              string capitalOfMass = capitals["Massachusetts"];
              Console.WriteLine("The capital of Massachusetts is {0}", capitalOfMass);
              string capitalOfMaryland = capitals["Maryland"];
              Console.WriteLine("The capital of Maryland is {0}", capitalOfMaryland);
              */
            var theStates = State.GetStates();
            int populationOfAlaska = theStates["Alaska"].Population;
            Console.WriteLine("The population of Alaska is {0}", populationOfAlaska);
        }

    }
}
