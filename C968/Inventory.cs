using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMangementSystem
{
    public class Inventory
    {
        public static BindingList<Products> Products = new BindingList<Products>();
        public static BindingList<Parts> Parts = new BindingList<Parts>();


        //methods for products
        public static void AddProduct(Products prod)
        {
            Products.Add(prod);
        }
        public static bool RemoveProduct(int prodID)
        {
            bool success = false;
            foreach (Products prod in Products)
            {
                if (prodID == prod.ProductID)
                {
                    Products.Remove(prod);
                    return success = true;
                }
                else
                {
                    MessageBox.Show("Error: Delete failed.");
                    return success = false;
                }
            }
            return success;
        }
        public static Products LookupProduct(int prodID)
        {
            foreach (Products prod in Products)
            {
                if (prod.ProductID == prodID)
                {
                    return prod;
                }
            }
            Products emptyProduct = new InventoryMangementSystem.Products();
            return emptyProduct;
        }
        public static void UpdateProduct(int prodID, Products updatedProduct)
        {
            foreach (Products currentProduct in Products)
            {
                if (currentProduct.ProductID == prodID)
                {
                    currentProduct.Name = updatedProduct.Name;
                    currentProduct.Inventory = updatedProduct.Inventory;
                    currentProduct.Price = updatedProduct.Price;
                    currentProduct.Max = updatedProduct.Max;
                    currentProduct.Min = updatedProduct.Min;
                    currentProduct.AssociatedParts = updatedProduct.AssociatedParts;
                    return;
                }
            }
        }


        //methods for parts
        public static void AddPart(Parts part)
        {
            Parts.Add(part);
        }
        public static bool DeletePart(int part)
        {
            Parts partToDelete = LookupPart(part);
            if (partToDelete == null)
            {
                return false;
            }
            else
            {
                Parts.Remove(partToDelete);
                return true;
            }
        }
        public static Parts LookupPart(int partID)
        {
            foreach (Parts part in Parts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            Parts emptyPart = new PartInHouse();
            return emptyPart;
        }
        public static void UpdatePart(int partID, Parts part)
        {
            DeletePart(partID);
            AddPart(part);
        }
        public static void ExampleItems()
        {
            Products exampleProd1 = new Products(2001, "Example Product", 5, 5.0m, 10, 5);
            Products exampleProd2 = new Products(2002, "Another Example", 25, 5.5m, 30, 10);
            Products.Add(exampleProd1);
            Products.Add(exampleProd2);

            Parts exampleInPart = new PartInHouse(1001, "Ex. InHouse Part", 10, 5.0m, 20, 10, 3001);
            Parts exampleOutPart = new PartOutSource(1002, "Ex. Outsource Part", 30, 1.0m, 45, 10, "Company One.");
            Parts.Add(exampleInPart);
            Parts.Add(exampleOutPart);

        }
    }
}