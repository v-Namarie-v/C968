using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMangementSystem
{
    public class Products
    {

        public BindingList<Parts> AssociatedParts = new BindingList<Parts>();
        private int prodID;
        private string name;
        private int inventory;
        private decimal price;
        private int max;
        private int min;

        public int ProductID { get; set; }
        public string Name { get; set; }
        public int Inventory { get; set; }
        public string Price
        {
            get { return price.ToString("C"); }
            set
            {
                if (value.StartsWith("$"))
                {
                    price = decimal.Parse(value.Substring(1));
                }
                else
                {
                    price = decimal.Parse(value);
                }
            }
        }
        public int Max { get; set; }
        public int Min { get; set; }

        public Products() { }
        public Products(int prodID, string name, int inventory, decimal price, int max, int min)
        {
            ProductID = prodID;
            Name = name;
            Inventory = inventory;
            Price = price.ToString();
            Max = max;
            Min = min;
        }

        //manipulate parts attached to products
        public void AddAssociatedPart(Parts part)
        {
            AssociatedParts.Add(part);
        }
        public bool RemoveAssociatedPart(int partID)
        {
            bool success = false;
            foreach (Parts part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    AssociatedParts.Remove(part);
                    return success = true;
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
        public Parts LookupAssociatedPart(int partID)
        {
            foreach (Parts part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            PartInHouse emptyInHousePart = new PartInHouse();
            return emptyInHousePart;
        }
    }
}