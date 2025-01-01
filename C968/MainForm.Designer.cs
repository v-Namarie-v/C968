namespace InventoryMangementSystem
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PartsGridView = new DataGridView();
            ProductsGridView = new DataGridView();
            PartSearchBttn = new Button();
            ProductSearchBttn = new Button();
            AddPartBttn = new Button();
            ModifyPartBttn = new Button();
            DeletePartBttn = new Button();
            AddProductBttn = new Button();
            ModifyProductBttn = new Button();
            DeleteProductBttn = new Button();
            InventoryMangementSystemLabel = new Label();
            PartsLabel = new Label();
            ProductsLabel = new Label();
            PartSearchBox = new TextBox();
            ProductSearchBox = new TextBox();
            ExitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)PartsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductsGridView).BeginInit();
            SuspendLayout();
            // 
            // PartsGridView
            // 
            PartsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PartsGridView.Location = new Point(85, 183);
            PartsGridView.Margin = new Padding(4, 3, 4, 3);
            PartsGridView.Name = "PartsGridView";
            PartsGridView.RowHeadersVisible = false;
            PartsGridView.RowHeadersWidth = 51;
            PartsGridView.Size = new Size(1076, 438);
            PartsGridView.TabIndex = 0;
            // 
            // ProductsGridView
            // 
            ProductsGridView.AllowUserToAddRows = false;
            ProductsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsGridView.Location = new Point(1209, 175);
            ProductsGridView.Margin = new Padding(4, 3, 4, 3);
            ProductsGridView.Name = "ProductsGridView";
            ProductsGridView.RowHeadersVisible = false;
            ProductsGridView.RowHeadersWidth = 51;
            ProductsGridView.Size = new Size(1076, 438);
            ProductsGridView.TabIndex = 1;
            // 
            // PartSearchBttn
            // 
            PartSearchBttn.Location = new Point(1044, 107);
            PartSearchBttn.Margin = new Padding(4, 3, 4, 3);
            PartSearchBttn.Name = "PartSearchBttn";
            PartSearchBttn.Size = new Size(117, 37);
            PartSearchBttn.TabIndex = 2;
            PartSearchBttn.Text = "Search";
            PartSearchBttn.UseVisualStyleBackColor = true;
            PartSearchBttn.Click += PartSearchBttn_Click;
            // 
            // ProductSearchBttn
            // 
            ProductSearchBttn.Location = new Point(2167, 108);
            ProductSearchBttn.Margin = new Padding(4, 3, 4, 3);
            ProductSearchBttn.Name = "ProductSearchBttn";
            ProductSearchBttn.Size = new Size(117, 37);
            ProductSearchBttn.TabIndex = 3;
            ProductSearchBttn.Text = "Search";
            ProductSearchBttn.UseVisualStyleBackColor = true;
            ProductSearchBttn.Click += ProductSearchBttn_Click;
            // 
            // AddPartBttn
            // 
            AddPartBttn.Location = new Point(793, 627);
            AddPartBttn.Margin = new Padding(4, 3, 4, 3);
            AddPartBttn.Name = "AddPartBttn";
            AddPartBttn.Size = new Size(117, 37);
            AddPartBttn.TabIndex = 4;
            AddPartBttn.Text = "Add";
            AddPartBttn.UseVisualStyleBackColor = true;
            AddPartBttn.Click += AddPartBttn_Click;
            // 
            // ModifyPartBttn
            // 
            ModifyPartBttn.Location = new Point(919, 627);
            ModifyPartBttn.Margin = new Padding(4, 3, 4, 3);
            ModifyPartBttn.Name = "ModifyPartBttn";
            ModifyPartBttn.Size = new Size(117, 37);
            ModifyPartBttn.TabIndex = 5;
            ModifyPartBttn.Text = "Modify";
            ModifyPartBttn.UseVisualStyleBackColor = true;
            ModifyPartBttn.Click += ModifyPartBttn_Click;
            // 
            // DeletePartBttn
            // 
            DeletePartBttn.Location = new Point(1044, 627);
            DeletePartBttn.Margin = new Padding(4, 3, 4, 3);
            DeletePartBttn.Name = "DeletePartBttn";
            DeletePartBttn.Size = new Size(117, 37);
            DeletePartBttn.TabIndex = 6;
            DeletePartBttn.Text = "Delete";
            DeletePartBttn.UseVisualStyleBackColor = true;
            DeletePartBttn.Click += DeletePartBttn_Click;
            // 
            // AddProductBttn
            // 
            AddProductBttn.Location = new Point(1916, 627);
            AddProductBttn.Margin = new Padding(4, 3, 4, 3);
            AddProductBttn.Name = "AddProductBttn";
            AddProductBttn.Size = new Size(117, 37);
            AddProductBttn.TabIndex = 7;
            AddProductBttn.Text = "Add";
            AddProductBttn.UseVisualStyleBackColor = true;
            AddProductBttn.Click += AddProductBttn_Click;
            // 
            // ModifyProductBttn
            // 
            ModifyProductBttn.Location = new Point(2041, 627);
            ModifyProductBttn.Margin = new Padding(4, 3, 4, 3);
            ModifyProductBttn.Name = "ModifyProductBttn";
            ModifyProductBttn.Size = new Size(117, 37);
            ModifyProductBttn.TabIndex = 8;
            ModifyProductBttn.Text = "Modify";
            ModifyProductBttn.UseVisualStyleBackColor = true;
            ModifyProductBttn.Click += ModifyProductBttn_Click;
            // 
            // DeleteProductBttn
            // 
            DeleteProductBttn.Location = new Point(2167, 627);
            DeleteProductBttn.Margin = new Padding(4, 3, 4, 3);
            DeleteProductBttn.Name = "DeleteProductBttn";
            DeleteProductBttn.Size = new Size(117, 37);
            DeleteProductBttn.TabIndex = 9;
            DeleteProductBttn.Text = "Delete";
            DeleteProductBttn.UseVisualStyleBackColor = true;
            DeleteProductBttn.Click += DeleteProductBttn_Click;
            // 
            // InventoryMangementSystemLabel
            // 
            InventoryMangementSystemLabel.AutoSize = true;
            InventoryMangementSystemLabel.Font = new Font("Segoe UI", 14F);
            InventoryMangementSystemLabel.Location = new Point(14, 12);
            InventoryMangementSystemLabel.Margin = new Padding(4, 0, 4, 0);
            InventoryMangementSystemLabel.Name = "InventoryMangementSystemLabel";
            InventoryMangementSystemLabel.Size = new Size(401, 38);
            InventoryMangementSystemLabel.TabIndex = 10;
            InventoryMangementSystemLabel.Text = "Inventory Management System";
            // 
            // PartsLabel
            // 
            PartsLabel.AutoSize = true;
            PartsLabel.Font = new Font("Segoe UI", 12F);
            PartsLabel.Location = new Point(86, 137);
            PartsLabel.Margin = new Padding(4, 0, 4, 0);
            PartsLabel.Name = "PartsLabel";
            PartsLabel.Size = new Size(64, 32);
            PartsLabel.TabIndex = 11;
            PartsLabel.Text = "Parts";
            // 
            // ProductsLabel
            // 
            ProductsLabel.AutoSize = true;
            ProductsLabel.Font = new Font("Segoe UI", 12F);
            ProductsLabel.Location = new Point(1209, 137);
            ProductsLabel.Margin = new Padding(4, 0, 4, 0);
            ProductsLabel.Name = "ProductsLabel";
            ProductsLabel.Size = new Size(106, 32);
            ProductsLabel.TabIndex = 12;
            ProductsLabel.Text = "Products";
            // 
            // PartSearchBox
            // 
            PartSearchBox.Location = new Point(761, 103);
            PartSearchBox.Margin = new Padding(4, 3, 4, 3);
            PartSearchBox.Name = "PartSearchBox";
            PartSearchBox.Size = new Size(273, 31);
            PartSearchBox.TabIndex = 13;
            // 
            // ProductSearchBox
            // 
            ProductSearchBox.Location = new Point(1884, 108);
            ProductSearchBox.Margin = new Padding(4, 3, 4, 3);
            ProductSearchBox.Name = "ProductSearchBox";
            ProductSearchBox.Size = new Size(273, 31);
            ProductSearchBox.TabIndex = 14;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(2193, 778);
            ExitButton.Margin = new Padding(4, 3, 4, 3);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(117, 37);
            ExitButton.TabIndex = 15;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2327, 833);
            Controls.Add(ExitButton);
            Controls.Add(ProductSearchBox);
            Controls.Add(PartSearchBox);
            Controls.Add(ProductsLabel);
            Controls.Add(PartsLabel);
            Controls.Add(InventoryMangementSystemLabel);
            Controls.Add(DeleteProductBttn);
            Controls.Add(ModifyProductBttn);
            Controls.Add(AddProductBttn);
            Controls.Add(DeletePartBttn);
            Controls.Add(ModifyPartBttn);
            Controls.Add(AddPartBttn);
            Controls.Add(ProductSearchBttn);
            Controls.Add(PartSearchBttn);
            Controls.Add(ProductsGridView);
            Controls.Add(PartsGridView);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)PartsGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductsGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView PartsGridView;
        private DataGridView ProductsGridView;
        private Button PartSearchBttn;
        private Button ProductSearchBttn;
        private Button AddPartBttn;
        private Button ModifyPartBttn;
        private Button DeletePartBttn;
        private Button AddProductBttn;
        private Button ModifyProductBttn;
        private Button DeleteProductBttn;
        private Label InventoryMangementSystemLabel;
        private Label PartsLabel;
        private Label ProductsLabel;
        private TextBox PartSearchBox;
        private TextBox ProductSearchBox;
        private Button ExitButton;
    }
}
