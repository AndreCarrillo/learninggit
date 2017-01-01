using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTestApp
{
    class Warehouse
    {
        public int ID { get; set; }
        public string WarehouseName { get; set; }
        private List<Item> WarehouseArray = new List<Item>();
        private Dictionary<int, Item> myFirstDictionary = new Dictionary<int, Item>();

        
        public Warehouse(string Name, int ID)
        {
            WarehouseName = Name;
            this.ID = ID;
        }
        

        public void addItem(Item thing)
        {
            WarehouseArray.Add(thing);
        }
        
        public Item FindAndReturnItem(int itemID)
        {
            try
            {
                Item returnItem = WarehouseArray.Find(Item => Item.ID == itemID);
                Console.WriteLine("{0} found", returnItem.Name);
                return returnItem;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("item {0} not in stock", itemID);
                Item nullItem = null;
                return nullItem;
            }
            
            
           
        }
    }
}
