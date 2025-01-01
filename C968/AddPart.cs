using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMangementSystem
{
    public partial class AddPartForm : Form
    {

        public AddPartForm()
        {
            InitializeComponent();
         
        }

        static int idNum = 1002;
      
        private void AddPartForm_Load(object sender, EventArgs e)
        {
            idNum = idNum + 1;
            AddPartIDTxtBox.Text = idNum.ToString();
        }


        private void InHouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            AddPartMacCom.Text = "Machine ID";
        }

        private void OutsourceRadio_CheckedChanged(object sender, EventArgs e)
        {
            AddPartMacCom.Text = "Company ID";
        }

        private void SaveBttn_Click(object sender, EventArgs e)
        {
            int min;
            int max;
            int inv;
            decimal price;

            try
            {
                inv = int.Parse(AddPartInvTxtBox.Text);
                price = decimal.Parse(AddPartPriceTxtBox.Text);
                min = int.Parse(AddPartMinTxtBox.Text);
                max = int.Parse(AddPartMaxTxtBox.Text);
            }
            catch
            {
                MessageBox.Show("Error: The following fields must be numeric: Inventory, Price, Min, and Max!");
                return;
            }

            string name = AddPartNameTxtBox.Text;
            inv = int.Parse(AddPartInvTxtBox.Text);
            price = decimal.Parse(AddPartPriceTxtBox.Text);
            min = int.Parse(AddPartMinTxtBox.Text);
            max = int.Parse(AddPartMaxTxtBox.Text);

            if (min > max)
            {
                MessageBox.Show("Error: Min can not be greater than max!");
                return;
            }

            if (inv > max || inv < min)
            {
                MessageBox.Show("Error: Inventory value must be betweent min and max!");
                return;
            }

            if (InHouseRadio.Checked)
            {
                PartInHouse inHouse = new PartInHouse((Inventory.Parts.Count + 1), name, inv, price, max, min, int.Parse(AddPartMacComDTxtBox.Text));
                Inventory.Parts.Add(inHouse);
            }
            else
            {
                PartOutSource outSource = new PartOutSource((Inventory.Parts.Count + 1), name, inv, price, max, min, AddPartMacComDTxtBox.Text);
                Inventory.Parts.Add(outSource);
            }
            Close();
        }

        private void CancelBttn_Click(object sender, EventArgs e)
        {
            this.Close();


        }
    }
}
//test commit