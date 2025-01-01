namespace InventoryMangementSystem
{
    partial class AddPartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPartForm));
            AddPartLabel = new Label();
            InHouseRadio = new RadioButton();
            OutsourceRadio = new RadioButton();
            AddPartIDTxtBox = new TextBox();
            AddPartNameTxtBox = new TextBox();
            AddPartInvTxtBox = new TextBox();
            AddPartMinTxtBox = new TextBox();
            AddPartPriceTxtBox = new TextBox();
            AddPartMacComDTxtBox = new TextBox();
            AddPartMaxTxtBox = new TextBox();
            SaveBttn = new Button();
            CancelBttn = new Button();
            AddPartID = new Label();
            AddPartName = new Label();
            AddPartInventory = new Label();
            AddPartPrice = new Label();
            AddPartMax = new Label();
            AddPartMin = new Label();
            AddPartMacCom = new Label();
            SuspendLayout();
            // 
            // AddPartLabel
            // 
            AddPartLabel.AutoSize = true;
            AddPartLabel.Font = new Font("Segoe UI", 12F);
            AddPartLabel.Location = new Point(17, 15);
            AddPartLabel.Margin = new Padding(4, 0, 4, 0);
            AddPartLabel.Name = "AddPartLabel";
            AddPartLabel.Size = new Size(104, 32);
            AddPartLabel.TabIndex = 0;
            AddPartLabel.Text = "Add Part";
            // 
            // InHouseRadio
            // 
            InHouseRadio.AutoSize = true;
            InHouseRadio.Location = new Point(149, 88);
            InHouseRadio.Margin = new Padding(4, 5, 4, 5);
            InHouseRadio.Name = "InHouseRadio";
            InHouseRadio.Size = new Size(110, 29);
            InHouseRadio.TabIndex = 1;
            InHouseRadio.TabStop = true;
            InHouseRadio.Text = "In-House";
            InHouseRadio.UseVisualStyleBackColor = true;
            InHouseRadio.CheckedChanged += InHouseRadio_CheckedChanged;
            // 
            // OutsourceRadio
            // 
            OutsourceRadio.AutoSize = true;
            OutsourceRadio.Location = new Point(327, 88);
            OutsourceRadio.Margin = new Padding(4, 5, 4, 5);
            OutsourceRadio.Name = "OutsourceRadio";
            OutsourceRadio.Size = new Size(130, 29);
            OutsourceRadio.TabIndex = 2;
            OutsourceRadio.TabStop = true;
            OutsourceRadio.Text = "Outsourced";
            OutsourceRadio.UseVisualStyleBackColor = true;
            OutsourceRadio.CheckedChanged += OutsourceRadio_CheckedChanged;
            // 
            // AddPartIDTxtBox
            // 
            AddPartIDTxtBox.Location = new Point(200, 183);
            AddPartIDTxtBox.Margin = new Padding(4, 5, 4, 5);
            AddPartIDTxtBox.Name = "AddPartIDTxtBox";
            AddPartIDTxtBox.ReadOnly = true;
            AddPartIDTxtBox.Size = new Size(225, 31);
            AddPartIDTxtBox.TabIndex = 3;
            // 
            // AddPartNameTxtBox
            // 
            AddPartNameTxtBox.Location = new Point(200, 257);
            AddPartNameTxtBox.Margin = new Padding(4, 5, 4, 5);
            AddPartNameTxtBox.Name = "AddPartNameTxtBox";
            AddPartNameTxtBox.Size = new Size(225, 31);
            AddPartNameTxtBox.TabIndex = 4;
            // 
            // AddPartInvTxtBox
            // 
            AddPartInvTxtBox.Location = new Point(200, 335);
            AddPartInvTxtBox.Margin = new Padding(4, 5, 4, 5);
            AddPartInvTxtBox.Name = "AddPartInvTxtBox";
            AddPartInvTxtBox.Size = new Size(225, 31);
            AddPartInvTxtBox.TabIndex = 5;
            // 
            // AddPartMinTxtBox
            // 
            AddPartMinTxtBox.Location = new Point(200, 485);
            AddPartMinTxtBox.Margin = new Padding(4, 5, 4, 5);
            AddPartMinTxtBox.Name = "AddPartMinTxtBox";
            AddPartMinTxtBox.Size = new Size(81, 31);
            AddPartMinTxtBox.TabIndex = 6;
            // 
            // AddPartPriceTxtBox
            // 
            AddPartPriceTxtBox.Location = new Point(200, 415);
            AddPartPriceTxtBox.Margin = new Padding(4, 5, 4, 5);
            AddPartPriceTxtBox.Name = "AddPartPriceTxtBox";
            AddPartPriceTxtBox.Size = new Size(225, 31);
            AddPartPriceTxtBox.TabIndex = 7;
            // 
            // AddPartMacComDTxtBox
            // 
            AddPartMacComDTxtBox.Location = new Point(200, 552);
            AddPartMacComDTxtBox.Margin = new Padding(4, 5, 4, 5);
            AddPartMacComDTxtBox.Name = "AddPartMacComDTxtBox";
            AddPartMacComDTxtBox.Size = new Size(225, 31);
            AddPartMacComDTxtBox.TabIndex = 8;
            // 
            // AddPartMaxTxtBox
            // 
            AddPartMaxTxtBox.Location = new Point(344, 483);
            AddPartMaxTxtBox.Margin = new Padding(4, 5, 4, 5);
            AddPartMaxTxtBox.Name = "AddPartMaxTxtBox";
            AddPartMaxTxtBox.Size = new Size(81, 31);
            AddPartMaxTxtBox.TabIndex = 9;
            // 
            // SaveBttn
            // 
            SaveBttn.Location = new Point(307, 663);
            SaveBttn.Margin = new Padding(4, 5, 4, 5);
            SaveBttn.Name = "SaveBttn";
            SaveBttn.Size = new Size(107, 38);
            SaveBttn.TabIndex = 10;
            SaveBttn.Text = "Save";
            SaveBttn.UseVisualStyleBackColor = true;
            SaveBttn.Click += SaveBttn_Click;
            // 
            // CancelBttn
            // 
            CancelBttn.Location = new Point(436, 663);
            CancelBttn.Margin = new Padding(4, 5, 4, 5);
            CancelBttn.Name = "CancelBttn";
            CancelBttn.Size = new Size(107, 38);
            CancelBttn.TabIndex = 11;
            CancelBttn.Text = "Cancel";
            CancelBttn.UseVisualStyleBackColor = true;
            CancelBttn.Click += CancelBttn_Click;
            // 
            // AddPartID
            // 
            AddPartID.AutoSize = true;
            AddPartID.Location = new Point(166, 188);
            AddPartID.Margin = new Padding(4, 0, 4, 0);
            AddPartID.Name = "AddPartID";
            AddPartID.Size = new Size(30, 25);
            AddPartID.TabIndex = 12;
            AddPartID.Text = "ID";
            // 
            // AddPartName
            // 
            AddPartName.AutoSize = true;
            AddPartName.Location = new Point(136, 262);
            AddPartName.Margin = new Padding(4, 0, 4, 0);
            AddPartName.Name = "AddPartName";
            AddPartName.Size = new Size(59, 25);
            AddPartName.TabIndex = 13;
            AddPartName.Text = "Name";
            // 
            // AddPartInventory
            // 
            AddPartInventory.Location = new Point(111, 335);
            AddPartInventory.Margin = new Padding(4, 0, 4, 0);
            AddPartInventory.Name = "AddPartInventory";
            AddPartInventory.Size = new Size(81, 38);
            AddPartInventory.TabIndex = 14;
            AddPartInventory.Text = "Inventory";
            AddPartInventory.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AddPartPrice
            // 
            AddPartPrice.Location = new Point(103, 413);
            AddPartPrice.Margin = new Padding(4, 0, 4, 0);
            AddPartPrice.Name = "AddPartPrice";
            AddPartPrice.Size = new Size(89, 38);
            AddPartPrice.TabIndex = 15;
            AddPartPrice.Text = "Price/Cost";
            AddPartPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AddPartMax
            // 
            AddPartMax.Location = new Point(293, 488);
            AddPartMax.Margin = new Padding(4, 0, 4, 0);
            AddPartMax.Name = "AddPartMax";
            AddPartMax.Size = new Size(43, 38);
            AddPartMax.TabIndex = 16;
            AddPartMax.Text = "Max";
            AddPartMax.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AddPartMin
            // 
            AddPartMin.AutoSize = true;
            AddPartMin.Location = new Point(151, 495);
            AddPartMin.Margin = new Padding(4, 0, 4, 0);
            AddPartMin.Name = "AddPartMin";
            AddPartMin.Size = new Size(42, 25);
            AddPartMin.TabIndex = 17;
            AddPartMin.Text = "Min";
            // 
            // AddPartMacCom
            // 
            AddPartMacCom.Location = new Point(36, 552);
            AddPartMacCom.Margin = new Padding(4, 0, 4, 0);
            AddPartMacCom.Name = "AddPartMacCom";
            AddPartMacCom.Size = new Size(157, 38);
            AddPartMacCom.TabIndex = 18;
            AddPartMacCom.Text = "Machine ID";
            AddPartMacCom.TextAlign = ContentAlignment.MiddleRight;
            // 
            // AddPartForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 743);
            Controls.Add(AddPartMacCom);
            Controls.Add(AddPartMin);
            Controls.Add(AddPartMax);
            Controls.Add(AddPartPrice);
            Controls.Add(AddPartInventory);
            Controls.Add(AddPartName);
            Controls.Add(AddPartID);
            Controls.Add(CancelBttn);
            Controls.Add(SaveBttn);
            Controls.Add(AddPartMaxTxtBox);
            Controls.Add(AddPartMacComDTxtBox);
            Controls.Add(AddPartPriceTxtBox);
            Controls.Add(AddPartMinTxtBox);
            Controls.Add(AddPartInvTxtBox);
            Controls.Add(AddPartNameTxtBox);
            Controls.Add(AddPartIDTxtBox);
            Controls.Add(OutsourceRadio);
            Controls.Add(InHouseRadio);
            Controls.Add(AddPartLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "AddPartForm";
            RightToLeftLayout = true;
            Text = "Part";
            Load += AddPartForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AddPartLabel;
        private RadioButton InHouseRadio;
        private RadioButton OutsourceRadio;
        private TextBox AddPartIDTxtBox;
        private TextBox AddPartNameTxtBox;
        private TextBox AddPartInvTxtBox;
        private TextBox AddPartMinTxtBox;
        private TextBox AddPartPriceTxtBox;
        private TextBox AddPartMacComDTxtBox;
        private TextBox AddPartMaxTxtBox;
        private Button SaveBttn;
        private Button CancelBttn;
        private Label AddPartID;
        private Label AddPartName;
        private Label AddPartInventory;
        private Label AddPartPrice;
        private Label AddPartMax;
        private Label AddPartMin;
        private Label AddPartMacCom;
    }
}