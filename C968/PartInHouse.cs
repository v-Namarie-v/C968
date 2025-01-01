using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InventoryMangementSystem
{
    public class PartInHouse : Parts
    {
        private int machID;
        public int MachineID { get; set; }
        public PartInHouse() { }
        public PartInHouse(int partID, string name, int inventory, decimal price, int max, int min)
        {
            PartID = partID;
            Name = name;
            Inventory = inventory;
            Price = price.ToString();
            Max = max;
            Min = min;
        }
        public PartInHouse(int partID, string name, int inventory, decimal price, int max, int min, int machID)
        {
            PartID = partID;
            Name = name;
            Inventory = inventory;
            Price = price.ToString();
            Max = max;
            Min = min;
            MachineID = machID;
        }

    }
}

//test commit