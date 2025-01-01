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
    public partial class ModifyPart : Form
    {
        MainForm MainWindow = (MainForm)Application.OpenForms["MainForm"];

        public ModifyPart(PartInHouse inHouse)
        {
            InitializeComponent();
            ModifyPartIDTxtBox.Text = inHouse.PartID.ToString();
            ModifyPartNameTxtBox.Text = inHouse.Name;
            ModifyPartInvTxtBox.Text = inHouse.Inventory.ToString();
            ModifyPartPriceTxtBox.Text = inHouse.Price.Substring(1).ToString();
            ModifyPartMinTxtBox.Text = inHouse.Min.ToString();
            ModifyPartMaxTxtBox.Text = inHouse.Max.ToString();
            ModifyPartMacComTxtBox.Text = inHouse.MachineID.ToString();
        }

        public ModifyPart(PartOutSource partOutSource)
        {
            InitializeComponent();

        }
        private void CancelBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
//test commit