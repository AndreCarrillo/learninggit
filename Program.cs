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
            var myComputer = new Computer();
            myComputer.ID = 110;

            Item mySecondComputer = new Computer();
            mySecondComputer.ID = 111;
            Computer mySecondComputer2 = mySecondComputer as Computer;
            string myCPUType = mySecondComputer2.CPUType;
            mySecondComputer2.Name = "Juniper";
            mySecondComputer2.CPUType = "i5";
            mySecondComputer2.Purchase();
        }
    }
}
