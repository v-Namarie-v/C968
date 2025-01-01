using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMangementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Inventory.ExampleItems();

            var partTable = new BindingSource();
            partTable.DataSource = Inventory.Parts;
            PartsGridView.DataSource = partTable;

            var prodTable = new BindingSource();
            prodTable.DataSource = Inventory.Products;
            ProductsGridView.DataSource = prodTable;
            //test commit
        }
        private void PartSearchBttn_Click(object sender, EventArgs e)
        {

        }

        private void AddPartBttn_Click(object sender, EventArgs e)
        {
            new AddPartForm().ShowDialog();
        }

        private void ModifyPartBttn_Click(object sender, EventArgs e)
        {
            if (PartsGridView.CurrentRow.DataBoundItem.GetType() == typeof(InventoryMangementSystem.PartInHouse)) 
            {
                PartInHouse inHousePart = (PartInHouse)PartsGridView.CurrentRow.DataBoundItem;
                new ModifyPart(inHousePart).ShowDialog();
            }
            else
            {
                PartOutSource outsourcedPart = (PartOutSource)PartsGridView.CurrentRow.DataBoundItem;
                new ModifyPart(outsourcedPart).ShowDialog();
            }
        }

        private void DeletePartBttn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this item? It can not be undone.", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in PartsGridView.SelectedRows)
                {
                    PartsGridView.Rows.RemoveAt(row.Index);
                }
            }
            else return;
        }
  
        private void ProductSearchBttn_Click(object sender, EventArgs e)
        {
            int searchValue = int.Parse(PartSearchBox.Text);

            if (searchValue < 1) return;

            Parts match = Inventory.LookupPart(int.Parse(PartSearchBox.Text));


            foreach (DataGridViewRow row in PartsGridView.Rows)
            {
                Parts part = (Parts)row.DataBoundItem;
                if (part.PartID == match.PartID)
                {
                    row.Selected = true;
                    break;
                }
                else
                {
                    row.Selected = false;
                }
            }
        }

        private void AddProductBttn_Click(object sender, EventArgs e)
        {
            new AddProduct().ShowDialog();
        }

        private void ModifyProductBttn_Click(object sender, EventArgs e)
        {
            Products selectedProduct = (Products)ProductsGridView.CurrentRow.DataBoundItem;
            new ModifyProduct().ShowDialog();   
        }

        private void DeleteProductBttn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete? This cannot be undone.", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Products product = (Products)ProductsGridView.CurrentRow.DataBoundItem;
                if (product.AssociatedParts.Count > 0)
                {
                    MessageBox.Show("Cannot delete product with associated parts. Please remove parts attached to this product.");
                    return;
                }
                foreach (DataGridViewRow row in ProductsGridView.SelectedRows)
                {
                    ProductsGridView.Rows.RemoveAt(row.Index);
                }
            }
            else return;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
