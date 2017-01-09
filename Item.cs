using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsharpTestApp
{
    class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual void Purchase()
        {
            Console.WriteLine("Purchasing {0}", Name);
        }
        public static Item GetItem()
        {
            var newItem = new Item();
            newItem.ID = 0;
            newItem.Name = "newItem";
            return newItem;
        }
    }
    
    
   class Software : Item
    {
        public string ISBN { get; set; }
        public override void Purchase()
        {
            base.Purchase();
            Console.WriteLine("ISBN is {0}", ISBN);
        }
    }

    class Hardware : Item
    {
        public string SerialNumber { get; set; }
    }

    class Computer : Hardware
    {
        public string CPUType { get; set; }
        public string Disks { get; set; }
        public override void Purchase()
        {
            base.Purchase();
            Console.WriteLine("CPUType is {0}", CPUType);
        }
    }

    class Peripheral : Hardware
    {
        public string Description { get; set; }
    }
    
}