namespace InventoryMangementSystem
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            AddProductLabel = new Label();
            AddProductSearchBttn = new Button();
            AddProductSearchBox = new TextBox();
            AddIDtxtBox = new TextBox();
            AddNameTxtBox = new TextBox();
            AddInventoryTxtBox = new TextBox();
            AddPriceTxtBox = new TextBox();
            AddMaxTxtBox = new TextBox();
            AddMinTxtBox = new TextBox();
            AddCandidatePartsGrid = new DataGridView();
            ModifyProductPartID = new DataGridViewTextBoxColumn();
            AddProductName = new DataGridViewTextBoxColumn();
            AddProductInventory = new DataGridViewTextBoxColumn();
            AddProductPrice = new DataGridViewTextBoxColumn();
            AddProductMin = new DataGridViewTextBoxColumn();
            AddProductMax = new DataGridViewTextBoxColumn();
            AddAssociatedPartsGrid = new DataGridView();
            ASPartID = new DataGridViewTextBoxColumn();
            ASName = new DataGridViewTextBoxColumn();
            ASInventory = new DataGridViewTextBoxColumn();
            ASPrice = new DataGridViewTextBoxColumn();
            ASMin = new DataGridViewTextBoxColumn();
            AsMax = new DataGridViewTextBoxColumn();
            ProductIDlabel = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ProductAddBtn = new Button();
            ProductDeleteBttn = new Button();
            AddProductSave = new Button();
            AddProductCancel = new Button();
            CandidatePartsLabel = new Label();
            AsProductLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)AddCandidatePartsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddAssociatedPartsGrid).BeginInit();
            SuspendLayout();
            // 
            // AddProductLabel
            // 
            AddProductLabel.AutoSize = true;
            AddProductLabel.Font = new Font("Segoe UI", 12F);
            AddProductLabel.Location = new Point(17, 15);
            AddProductLabel.Margin = new Padding(4, 0, 4, 0);
            AddProductLabel.Name = "AddProductLabel";
            AddProductLabel.Size = new Size(146, 32);
            AddProductLabel.TabIndex = 0;
            AddProductLabel.Text = "Add Product";
            // 
            // AddProductSearchBttn
            // 
            AddProductSearchBttn.Location = new Point(1289, 35);
            AddProductSearchBttn.Margin = new Padding(4, 5, 4, 5);
            AddProductSearchBttn.Name = "AddProductSearchBttn";
            AddProductSearchBttn.Size = new Size(107, 38);
            AddProductSearchBttn.TabIndex = 1;
            AddProductSearchBttn.Text = "Search";
            AddProductSearchBttn.UseVisualStyleBackColor = true;
            // 
            // AddProductSearchBox
            // 
            AddProductSearchBox.Location = new Point(973, 35);
            AddProductSearchBox.Margin = new Padding(4, 5, 4, 5);
            AddProductSearchBox.Name = "AddProductSearchBox";
            AddProductSearchBox.Size = new Size(305, 31);
            AddProductSearchBox.TabIndex = 2;
            // 
            // AddIDtxtBox
            // 
            AddIDtxtBox.Location = new Point(169, 185);
            AddIDtxtBox.Margin = new Padding(4, 5, 4, 5);
            AddIDtxtBox.Name = "AddIDtxtBox";
            AddIDtxtBox.ReadOnly = true;
            AddIDtxtBox.Size = new Size(225, 31);
            AddIDtxtBox.TabIndex = 6;
            // 
            // AddNameTxtBox
            // 
            AddNameTxtBox.Location = new Point(169, 275);
            AddNameTxtBox.Margin = new Padding(4, 5, 4, 5);
            AddNameTxtBox.Name = "AddNameTxtBox";
            AddNameTxtBox.Size = new Size(225, 31);
            AddNameTxtBox.TabIndex = 7;
            // 
            // AddInventoryTxtBox
            // 
            AddInventoryTxtBox.Location = new Point(169, 360);
            AddInventoryTxtBox.Margin = new Padding(4, 5, 4, 5);
            AddInventoryTxtBox.Name = "AddInventoryTxtBox";
            AddInventoryTxtBox.Size = new Size(225, 31);
            AddInventoryTxtBox.TabIndex = 8;
            // 
            // AddPriceTxtBox
            // 
            AddPriceTxtBox.Location = new Point(169, 428);
            AddPriceTxtBox.Margin = new Padding(4, 5, 4, 5);
            AddPriceTxtBox.Name = "AddPriceTxtBox";
            AddPriceTxtBox.Size = new Size(225, 31);
            AddPriceTxtBox.TabIndex = 9;
            // 
            // AddMaxTxtBox
            // 
            AddMaxTxtBox.Location = new Point(313, 520);
            AddMaxTxtBox.Margin = new Padding(4, 5, 4, 5);
            AddMaxTxtBox.Name = "AddMaxTxtBox";
            AddMaxTxtBox.Size = new Size(81, 31);
            AddMaxTxtBox.TabIndex = 10;
            // 
            // AddMinTxtBox
            // 
            AddMinTxtBox.Location = new Point(166, 520);
            AddMinTxtBox.Margin = new Padding(4, 5, 4, 5);
            AddMinTxtBox.Name = "AddMinTxtBox";
            AddMinTxtBox.Size = new Size(81, 31);
            AddMinTxtBox.TabIndex = 11;
            // 
            // AddCandidatePartsGrid
            // 
            AddCandidatePartsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AddCandidatePartsGrid.Columns.AddRange(new DataGridViewColumn[] { ModifyProductPartID, AddProductName, AddProductInventory, AddProductPrice, AddProductMin, AddProductMax });
            AddCandidatePartsGrid.Location = new Point(534, 105);
            AddCandidatePartsGrid.Margin = new Padding(4, 5, 4, 5);
            AddCandidatePartsGrid.Name = "AddCandidatePartsGrid";
            AddCandidatePartsGrid.RowHeadersVisible = false;
            AddCandidatePartsGrid.RowHeadersWidth = 62;
            AddCandidatePartsGrid.Size = new Size(861, 250);
            AddCandidatePartsGrid.TabIndex = 12;
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
            // AddAssociatedPartsGrid
            // 
            AddAssociatedPartsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AddAssociatedPartsGrid.Columns.AddRange(new DataGridViewColumn[] { ASPartID, ASName, ASInventory, ASPrice, ASMin, AsMax });
            AddAssociatedPartsGrid.Location = new Point(534, 427);
            AddAssociatedPartsGrid.Margin = new Padding(4, 5, 4, 5);
            AddAssociatedPartsGrid.Name = "AddAssociatedPartsGrid";
            AddAssociatedPartsGrid.RowHeadersVisible = false;
            AddAssociatedPartsGrid.RowHeadersWidth = 62;
            AddAssociatedPartsGrid.Size = new Size(861, 250);
            AddAssociatedPartsGrid.TabIndex = 13;
            // 
            // ASPartID
            // 
            ASPartID.HeaderText = "Part ID";
            ASPartID.MinimumWidth = 8;
            ASPartID.Name = "ASPartID";
            ASPartID.Width = 150;
            // 
            // ASName
            // 
            ASName.HeaderText = "Name";
            ASName.MinimumWidth = 8;
            ASName.Name = "ASName";
            ASName.Width = 150;
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
            // ProductIDlabel
            // 
            ProductIDlabel.Location = new Point(17, 185);
            ProductIDlabel.Margin = new Padding(4, 0, 4, 0);
            ProductIDlabel.Name = "ProductIDlabel";
            ProductIDlabel.Size = new Size(143, 38);
            ProductIDlabel.TabIndex = 14;
            ProductIDlabel.Text = "ID";
            ProductIDlabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Location = new Point(17, 275);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(143, 38);
            label2.TabIndex = 15;
            label2.Text = "Name";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Location = new Point(17, 358);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(143, 38);
            label3.TabIndex = 16;
            label3.Text = "Inventory";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Location = new Point(17, 428);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(143, 38);
            label4.TabIndex = 17;
            label4.Text = "Price";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Location = new Point(97, 520);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(63, 38);
            label5.TabIndex = 18;
            label5.Text = "Min";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Location = new Point(257, 520);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(57, 38);
            label6.TabIndex = 19;
            label6.Text = "Max";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ProductAddBtn
            // 
            ProductAddBtn.Location = new Point(1289, 360);
            ProductAddBtn.Margin = new Padding(4, 5, 4, 5);
            ProductAddBtn.Name = "ProductAddBtn";
            ProductAddBtn.Size = new Size(107, 38);
            ProductAddBtn.TabIndex = 20;
            ProductAddBtn.Text = "Add";
            ProductAddBtn.UseVisualStyleBackColor = true;
            // 
            // ProductDeleteBttn
            // 
            ProductDeleteBttn.Location = new Point(1289, 687);
            ProductDeleteBttn.Margin = new Padding(4, 5, 4, 5);
            ProductDeleteBttn.Name = "ProductDeleteBttn";
            ProductDeleteBttn.Size = new Size(107, 38);
            ProductDeleteBttn.TabIndex = 21;
            ProductDeleteBttn.Text = "Delete";
            ProductDeleteBttn.UseVisualStyleBackColor = true;
            // 
            // AddProductSave
            // 
            AddProductSave.Location = new Point(1173, 760);
            AddProductSave.Margin = new Padding(4, 5, 4, 5);
            AddProductSave.Name = "AddProductSave";
            AddProductSave.Size = new Size(107, 38);
            AddProductSave.TabIndex = 22;
            AddProductSave.Text = "Save";
            AddProductSave.UseVisualStyleBackColor = true;
            // 
            // AddProductCancel
            // 
            AddProductCancel.Location = new Point(1289, 760);
            AddProductCancel.Margin = new Padding(4, 5, 4, 5);
            AddProductCancel.Name = "AddProductCancel";
            AddProductCancel.Size = new Size(107, 38);
            AddProductCancel.TabIndex = 23;
            AddProductCancel.Text = "Cancel";
            AddProductCancel.UseVisualStyleBackColor = true;
            // 
            // CandidatePartsLabel
            // 
            CandidatePartsLabel.AutoSize = true;
            CandidatePartsLabel.Location = new Point(534, 75);
            CandidatePartsLabel.Margin = new Padding(4, 0, 4, 0);
            CandidatePartsLabel.Name = "CandidatePartsLabel";
            CandidatePartsLabel.Size = new Size(160, 25);
            CandidatePartsLabel.TabIndex = 24;
            CandidatePartsLabel.Text = "All Candidate Parts";
            // 
            // AsProductLabel
            // 
            AsProductLabel.AutoSize = true;
            AsProductLabel.Location = new Point(534, 397);
            AsProductLabel.Margin = new Padding(4, 0, 4, 0);
            AsProductLabel.Name = "AsProductLabel";
            AsProductLabel.Size = new Size(279, 25);
            AsProductLabel.TabIndex = 25;
            AsProductLabel.Text = "Parts Associated with this Product";
            // 
            // AddProduct
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
            Controls.Add(AddAssociatedPartsGrid);
            Controls.Add(AddCandidatePartsGrid);
            Controls.Add(AddMinTxtBox);
            Controls.Add(AddMaxTxtBox);
            Controls.Add(AddPriceTxtBox);
            Controls.Add(AddInventoryTxtBox);
            Controls.Add(AddNameTxtBox);
            Controls.Add(AddIDtxtBox);
            Controls.Add(AddProductSearchBox);
            Controls.Add(AddProductSearchBttn);
            Controls.Add(AddProductLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "AddProduct";
            Text = "Product";
            ((System.ComponentModel.ISupportInitialize)AddCandidatePartsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddAssociatedPartsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AddProductLabel;
        private Button AddProductSearchBttn;
        private TextBox AddProductSearchBox;
        private TextBox AddIDtxtBox;
        private TextBox AddNameTxtBox;
        private TextBox AddInventoryTxtBox;
        private TextBox AddPriceTxtBox;
        private TextBox AddMaxTxtBox;
        private TextBox AddMinTxtBox;
        private DataGridView AddCandidatePartsGrid;
        private DataGridView AddAssociatedPartsGrid;
        private DataGridViewTextBoxColumn ModifyProductPartID;
        private DataGridViewTextBoxColumn AddProductName;
        private DataGridViewTextBoxColumn AddProductInventory;
        private DataGridViewTextBoxColumn AddProductPrice;
        private DataGridViewTextBoxColumn AddProductMin;
        private DataGridViewTextBoxColumn AddProductMax;
        private DataGridViewTextBoxColumn ASPartID;
        private DataGridViewTextBoxColumn ASName;
        private DataGridViewTextBoxColumn ASInventory;
        private DataGridViewTextBoxColumn ASPrice;
        private DataGridViewTextBoxColumn ASMin;
        private DataGridViewTextBoxColumn AsMax;
        private Label ProductIDlabel;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button ProductAddBtn;
        private Button ProductDeleteBttn;
        private Button AddProductSave;
        private Button AddProductCancel;
        private Label CandidatePartsLabel;
        private Label AsProductLabel;
    }
}