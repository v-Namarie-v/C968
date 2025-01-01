namespace InventoryMangementSystem
{
    partial class ModifyProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyProduct));
            AsProductLabel = new Label();
            ASInventory = new DataGridViewTextBoxColumn();
            ASPrice = new DataGridViewTextBoxColumn();
            ASMin = new DataGridViewTextBoxColumn();
            AsMax = new DataGridViewTextBoxColumn();
            ASName = new DataGridViewTextBoxColumn();
            CandidatePartsLabel = new Label();
            AddProductCancel = new Button();
            AddProductSave = new Button();
            ProductDeleteBttn = new Button();
            ProductAddBtn = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ProductIDlabel = new Label();
            ASPartID = new DataGridViewTextBoxColumn();
            ModifyAssociatedPartsGrid = new DataGridView();
            ModifyCandidatePartsGrid = new DataGridView();
            ModifyProductPartID = new DataGridViewTextBoxColumn();
            AddProductName = new DataGridViewTextBoxColumn();
            AddProductInventory = new DataGridViewTextBoxColumn();
            AddProductPrice = new DataGridViewTextBoxColumn();
            AddProductMin = new DataGridViewTextBoxColumn();
            AddProductMax = new DataGridViewTextBoxColumn();
            ModifyMinTxtBox = new TextBox();
            ModifyMaxTxtBox = new TextBox();
            ModifyPriceTxtBox = new TextBox();
            ModifyInventoryTxtBox = new TextBox();
            ModifyNameBox = new TextBox();
            ModifyIDbox = new TextBox();
            ModifyProductSearchBox = new TextBox();
            ModifyProductSearchBttn = new Button();
            ModifyProductLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)ModifyAssociatedPartsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ModifyCandidatePartsGrid).BeginInit();
            SuspendLayout();
            // 
            // AsProductLabel
            // 
            AsProductLabel.AutoSize = true;
            AsProductLabel.Location = new Point(543, 398);
            AsProductLabel.Margin = new Padding(4, 0, 4, 0);
            AsProductLabel.Name = "AsProductLabel";
            AsProductLabel.Size = new Size(279, 25);
            AsProductLabel.TabIndex = 48;
            AsProductLabel.Text = "Parts Associated with this Product";
            // 
            // ASInventory
            // 
            ASInventory.HeaderText = "Inventory";
            ASInventory.MinimumWidth = 8;
            ASInventory.Name = "ASInventory";
            ASInventory.Width = 150;
            // 
            // ASPrice
            // 
            ASPrice.HeaderText = "Price";
            ASPrice.MinimumWidth = 8;
            ASPrice.Name = "ASPrice";
            ASPrice.Width = 150;
            // 
            // ASMin
            // 
            ASMin.HeaderText = "Min";
            ASMin.MinimumWidth = 8;
            ASMin.Name = "ASMin";
            ASMin.Width = 150;
            // 
            // AsMax
            // 
            AsMax.HeaderText = "Max";
            AsMax.MinimumWidth = 8;
            AsMax.Name = "AsMax";
            AsMax.Width = 150;
            // 
            // ASName
            // 
            ASName.HeaderText = "Name";
            ASName.MinimumWidth = 8;
            ASName.Name = "ASName";
            ASName.Width = 150;
            // 
            // CandidatePartsLabel
            // 
            CandidatePartsLabel.AutoSize = true;
            CandidatePartsLabel.Location = new Point(543, 77);
            CandidatePartsLabel.Margin = new Padding(4, 0, 4, 0);
            CandidatePartsLabel.Name = "CandidatePartsLabel";
            CandidatePartsLabel.Size = new Size(160, 25);
            CandidatePartsLabel.TabIndex = 47;
            CandidatePartsLabel.Text = "All Candidate Parts";
            // 
            // AddProductCancel
            // 
            AddProductCancel.Location = new Point(1297, 762);
            AddProductCancel.Margin = new Padding(4, 5, 4, 5);
            AddProductCancel.Name = "AddProductCancel";
            AddProductCancel.Size = new Size(107, 38);
            AddProductCancel.TabIndex = 46;
            AddProductCancel.Text = "Cancel";
            AddProductCancel.UseVisualStyleBackColor = true;
            // 
            // AddProductSave
            // 
            AddProductSave.Location = new Point(1181, 762);
            AddProductSave.Margin = new Padding(4, 5, 4, 5);
            AddProductSave.Name = "AddProductSave";
            AddProductSave.Size = new Size(107, 38);
            AddProductSave.TabIndex = 45;
            AddProductSave.Text = "Save";
            AddProductSave.UseVisualStyleBackColor = true;
            // 
            // ProductDeleteBttn
            // 
            ProductDeleteBttn.Location = new Point(1297, 688);
            ProductDeleteBttn.Margin = new Padding(4, 5, 4, 5);
            ProductDeleteBttn.Name = "ProductDeleteBttn";
            ProductDeleteBttn.Size = new Size(107, 38);
            ProductDeleteBttn.TabIndex = 44;
            ProductDeleteBttn.Text = "Delete";
            ProductDeleteBttn.UseVisualStyleBackColor = true;
            // 
            // ProductAddBtn
            // 
            ProductAddBtn.Location = new Point(1297, 362);
            ProductAddBtn.Margin = new Padding(4, 5, 4, 5);
            ProductAddBtn.Name = "ProductAddBtn";
            ProductAddBtn.Size = new Size(107, 38);
            ProductAddBtn.TabIndex = 43;
            ProductAddBtn.Text = "Add";
            ProductAddBtn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.Location = new Point(266, 522);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(57, 38);
            label6.TabIndex = 42;
            label6.Text = "Max";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Location = new Point(106, 522);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(63, 38);
            label5.TabIndex = 41;
            label5.Text = "Min";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Location = new Point(26, 430);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(143, 38);
            label4.TabIndex = 40;
            label4.Text = "Price";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Location = new Point(26, 360);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(143, 38);
            label3.TabIndex = 39;
            label3.Text = "Inventory";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Location = new Point(26, 277);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(143, 38);
            label2.TabIndex = 38;
            label2.Text = "Name";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ProductIDlabel
            // 
            ProductIDlabel.Location = new Point(26, 187);
            ProductIDlabel.Margin = new Padding(4, 0, 4, 0);
            ProductIDlabel.Name = "ProductIDlabel";
            ProductIDlabel.Size = new Size(143, 38);
            ProductIDlabel.TabIndex = 37;
            ProductIDlabel.Text = "ID";
            ProductIDlabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ASPartID
            // 
            ASPartID.HeaderText = "Part ID";
            ASPartID.MinimumWidth = 8;
            ASPartID.Name = "ASPartID";
            ASPartID.Width = 150;
            // 
            // ModifyAssociatedPartsGrid
            // 
            ModifyAssociatedPartsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ModifyAssociatedPartsGrid.Columns.AddRange(new DataGridViewColumn[] { ASPartID, ASName, ASInventory, ASPrice, ASMin, AsMax });
            ModifyAssociatedPartsGrid.Location = new Point(543, 428);
            ModifyAssociatedPartsGrid.Margin = new Padding(4, 5, 4, 5);
            ModifyAssociatedPartsGrid.Name = "ModifyAssociatedPartsGrid";
            ModifyAssociatedPartsGrid.RowHeadersVisible = false;
            ModifyAssociatedPartsGrid.RowHeadersWidth = 62;
            ModifyAssociatedPartsGrid.Size = new Size(861, 250);
            ModifyAssociatedPartsGrid.TabIndex = 36;
            // 
            // ModifyCandidatePartsGrid
            // 
            ModifyCandidatePartsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ModifyCandidatePartsGrid.Columns.AddRange(new DataGridViewColumn[] { ModifyProductPartID, AddProductName, AddProductInventory, AddProductPrice, AddProductMin, AddProductMax });
            ModifyCandidatePartsGrid.Location = new Point(543, 107);
            ModifyCandidatePartsGrid.Margin = new Padding(4, 5, 4, 5);
            ModifyCandidatePartsGrid.Name = "ModifyCandidatePartsGrid";
            ModifyCandidatePartsGrid.RowHeadersVisible = false;
            ModifyCandidatePartsGrid.RowHeadersWidth = 62;
            ModifyCandidatePartsGrid.Size = new Size(861, 250);
            ModifyCandidatePartsGrid.TabIndex = 35;
            // 
            // ModifyProductPartID
            // 
            ModifyProductPartID.HeaderText = "Part ID";
            ModifyProductPartID.MinimumWidth = 8;
            ModifyProductPartID.Name = "ModifyProductPartID";
            ModifyProductPartID.Width = 150;
            // 
            // AddProductName
            // 
            AddProductName.HeaderText = "Name";
            AddProductName.MinimumWidth = 8;
            AddProductName.Name = "AddProductName";
            AddProductName.Width = 150;
            // 
            // AddProductInventory
            // 
            AddProductInventory.HeaderText = "Inventory";
            AddProductInventory.MinimumWidth = 8;
            AddProductInventory.Name = "AddProductInventory";
            AddProductInventory.Width = 150;
            // 
            // AddProductPrice
            // 
            AddProductPrice.HeaderText = "Price";
            AddProductPrice.MinimumWidth = 8;
            AddProductPrice.Name = "AddProductPrice";
            AddProductPrice.Width = 150;
            // 
            // AddProductMin
            // 
            AddProductMin.HeaderText = "Min";
            AddProductMin.MinimumWidth = 8;
            AddProductMin.Name = "AddProductMin";
            AddProductMin.Width = 150;
            // 
            // AddProductMax
            // 
            AddProductMax.HeaderText = "Max";
            AddProductMax.MinimumWidth = 8;
            AddProductMax.Name = "AddProductMax";
            AddProductMax.Width = 150;
            // 
            // ModifyMinTxtBox
            // 
            ModifyMinTxtBox.Location = new Point(174, 522);
            ModifyMinTxtBox.Margin = new Padding(4, 5, 4, 5);
            ModifyMinTxtBox.Name = "ModifyMinTxtBox";
            ModifyMinTxtBox.Size = new Size(81, 31);
            ModifyMinTxtBox.TabIndex = 34;
            // 
            // ModifyMaxTxtBox
            // 
            ModifyMaxTxtBox.Location = new Point(321, 522);
            ModifyMaxTxtBox.Margin = new Padding(4, 5, 4, 5);
            ModifyMaxTxtBox.Name = "ModifyMaxTxtBox";
            ModifyMaxTxtBox.Size = new Size(81, 31);
            ModifyMaxTxtBox.TabIndex = 33;
            // 
            // ModifyPriceTxtBox
            // 
            ModifyPriceTxtBox.Location = new Point(177, 430);
            ModifyPriceTxtBox.Margin = new Padding(4, 5, 4, 5);
            ModifyPriceTxtBox.Name = "ModifyPriceTxtBox";
            ModifyPriceTxtBox.Size = new Size(225, 31);
            ModifyPriceTxtBox.TabIndex = 32;
            // 
            // ModifyInventoryTxtBox
            // 
            ModifyInventoryTxtBox.Location = new Point(177, 362);
            ModifyInventoryTxtBox.Margin = new Padding(4, 5, 4, 5);
            ModifyInventoryTxtBox.Name = "ModifyInventoryTxtBox";
            ModifyInventoryTxtBox.Size = new Size(225, 31);
            ModifyInventoryTxtBox.TabIndex = 31;
            // 
            // ModifyNameBox
            // 
            ModifyNameBox.Location = new Point(177, 277);
            ModifyNameBox.Margin = new Padding(4, 5, 4, 5);
            ModifyNameBox.Name = "ModifyNameBox";
            ModifyNameBox.Size = new Size(225, 31);
            ModifyNameBox.TabIndex = 30;
            // 
            // ModifyIDbox
            // 
            ModifyIDbox.Location = new Point(177, 187);
            ModifyIDbox.Margin = new Padding(4, 5, 4, 5);
            ModifyIDbox.Name = "ModifyIDbox";
            ModifyIDbox.ReadOnly = true;
            ModifyIDbox.Size = new Size(225, 31);
            ModifyIDbox.TabIndex = 29;
            // 
            // ModifyProductSearchBox
            // 
            ModifyProductSearchBox.Location = new Point(981, 37);
            ModifyProductSearchBox.Margin = new Padding(4, 5, 4, 5);
            ModifyProductSearchBox.Name = "ModifyProductSearchBox";
            ModifyProductSearchBox.Size = new Size(305, 31);
            ModifyProductSearchBox.TabIndex = 28;
            // 
            // ModifyProductSearchBttn
            // 
            ModifyProductSearchBttn.Location = new Point(1297, 37);
            ModifyProductSearchBttn.Margin = new Padding(4, 5, 4, 5);
            ModifyProductSearchBttn.Name = "ModifyProductSearchBttn";
            ModifyProductSearchBttn.Size = new Size(107, 38);
            ModifyProductSearchBttn.TabIndex = 27;
            ModifyProductSearchBttn.Text = "Search";
            ModifyProductSearchBttn.UseVisualStyleBackColor = true;
            // 
            // ModifyProductLabel
            // 
            ModifyProductLabel.AutoSize = true;
            ModifyProductLabel.Font = new Font("Segoe UI", 12F);
            ModifyProductLabel.Location = new Point(26, 17);
            ModifyProductLabel.Margin = new Padding(4, 0, 4, 0);
            ModifyProductLabel.Name = "ModifyProductLabel";
            ModifyProductLabel.Size = new Size(179, 32);
            ModifyProductLabel.TabIndex = 26;
            ModifyProductLabel.Text = "Modify Product";
            // 
            // ModifyProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1429, 818);
            Controls.Add(AsProductLabel);
            Controls.Add(CandidatePartsLabel);
            Controls.Add(AddProductCancel);
            Controls.Add(AddProductSave);
            Controls.Add(ProductDeleteBttn);
            Controls.Add(ProductAddBtn);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ProductIDlabel);
            Controls.Add(ModifyAssociatedPartsGrid);
            Controls.Add(ModifyCandidatePartsGrid);
            Controls.Add(ModifyMinTxtBox);
            Controls.Add(ModifyMaxTxtBox);
            Controls.Add(ModifyPriceTxtBox);
            Controls.Add(ModifyInventoryTxtBox);
            Controls.Add(ModifyNameBox);
            Controls.Add(ModifyIDbox);
            Controls.Add(ModifyProductSearchBox);
            Controls.Add(ModifyProductSearchBttn);
            Controls.Add(ModifyProductLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "ModifyProduct";
            Text = "Product";
            ((System.ComponentModel.ISupportInitialize)ModifyAssociatedPartsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)ModifyCandidatePartsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AsProductLabel;
        private DataGridViewTextBoxColumn ASInventory;
        private DataGridViewTextBoxColumn ASPrice;
        private DataGridViewTextBoxColumn ASMin;
        private DataGridViewTextBoxColumn AsMax;
        private DataGridViewTextBoxColumn ASName;
        private Label CandidatePartsLabel;
        private Button AddProductCancel;
        private Button AddProductSave;
        private Button ProductDeleteBttn;
        private Button ProductAddBtn;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label ProductIDlabel;
        private DataGridViewTextBoxColumn ASPartID;
        private DataGridView ModifyAssociatedPartsGrid;
        private DataGridView ModifyCandidatePartsGrid;
        private DataGridViewTextBoxColumn ModifyProductPartID;
        private DataGridViewTextBoxColumn AddProductName;
        private DataGridViewTextBoxColumn AddProductInventory;
        private DataGridViewTextBoxColumn AddProductPrice;
        private DataGridViewTextBoxColumn AddProductMin;
        private DataGridViewTextBoxColumn AddProductMax;
        private TextBox ModifyMinTxtBox;
        private TextBox ModifyMaxTxtBox;
        private TextBox ModifyPriceTxtBox;
        private TextBox ModifyInventoryTxtBox;
        private TextBox ModifyNameBox;
        private TextBox ModifyIDbox;
        private TextBox ModifyProductSearchBox;
        private Button ModifyProductSearchBttn;
        private Label ModifyProductLabel;
    }
}