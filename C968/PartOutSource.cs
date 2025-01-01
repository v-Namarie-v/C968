using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InventoryMangementSystem
{
    public class PartOutSource : Parts
    {
       
        public string CompName { get; set; }

        public PartOutSource(int partID, string name, int inventory, decimal price, int max, int min, string compName)
        {
            PartID = partID;
            Name = name;
            Inventory = inventory;
            Price = price.ToString();
            Min = min;
            Max = max;
            CompName = compName;
        }
    }
}
