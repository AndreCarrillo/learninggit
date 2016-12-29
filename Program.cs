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
            Warehouse newWarehouse = new Warehouse("houston Warehouse", 11101);
            var Item1 = new Item(101, "Microsoft Word");
            var Item2 = new Item(102, "Microsoft Excel");
            var Item3 = new Item(103, "Microsoft Powerpoint");
            newWarehouse.addItem(Item1);
            newWarehouse.addItem(Item2);
            newWarehouse.addItem(Item3);
          //  newWarehouse.FindAndReturnItem(101);
            newWarehouse.FindAndReturnItem(104);
        }
    }
}
