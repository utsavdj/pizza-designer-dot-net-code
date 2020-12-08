namespace PizzaDesigner
{
    partial class PizzaDesignerForm
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
	  this.components = new System.ComponentModel.Container();
	  this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
	  this.label1 = new System.Windows.Forms.Label();
	  this.label2 = new System.Windows.Forms.Label();
	  this.label3 = new System.Windows.Forms.Label();
	  this._pizzaDataGridView = new System.Windows.Forms.DataGridView();
	  this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
	  this.EnergyValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
	  this.PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
	  this.Vegetarian = new System.Windows.Forms.DataGridViewCheckBoxColumn();
	  this.retailPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
	  this.pizzaBindingSource = new System.Windows.Forms.BindingSource(this.components);
	  this._ingredientDataGridView = new System.Windows.Forms.DataGridView();
	  this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
	  this.servingSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
	  this.energyValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
	  this.purchasePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
	  this.vegetarianDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
	  this.ingredientBindingSource = new System.Windows.Forms.BindingSource(this.components);
	  this._toppingsDataGridView = new System.Windows.Forms.DataGridView();
	  this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
	  this.ToppingServingSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
	  this.vegetarianDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
	  this.toppingBindingSource = new System.Windows.Forms.BindingSource(this.components);
	  this._addToppingButton = new System.Windows.Forms.Button();
	  this._MenuButton = new System.Windows.Forms.Button();
	  this.tableLayoutPanel1.SuspendLayout();
	  ((System.ComponentModel.ISupportInitialize)(this._pizzaDataGridView)).BeginInit();
	  ((System.ComponentModel.ISupportInitialize)(this.pizzaBindingSource)).BeginInit();
	  ((System.ComponentModel.ISupportInitialize)(this._ingredientDataGridView)).BeginInit();
	  ((System.ComponentModel.ISupportInitialize)(this.ingredientBindingSource)).BeginInit();
	  ((System.ComponentModel.ISupportInitialize)(this._toppingsDataGridView)).BeginInit();
	  ((System.ComponentModel.ISupportInitialize)(this.toppingBindingSource)).BeginInit();
	  this.SuspendLayout();
	  // 
	  // tableLayoutPanel1
	  // 
	  this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
	  this.tableLayoutPanel1.ColumnCount = 3;
	  this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37F));
	  this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41F));
	  this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
	  this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
	  this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
	  this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
	  this.tableLayoutPanel1.Controls.Add(this._pizzaDataGridView, 0, 1);
	  this.tableLayoutPanel1.Controls.Add(this._ingredientDataGridView, 1, 1);
	  this.tableLayoutPanel1.Controls.Add(this._toppingsDataGridView, 2, 1);
	  this.tableLayoutPanel1.Controls.Add(this._addToppingButton, 1, 2);
	  this.tableLayoutPanel1.Controls.Add(this._MenuButton, 0, 2);
	  this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
	  this.tableLayoutPanel1.Name = "tableLayoutPanel1";
	  this.tableLayoutPanel1.RowCount = 3;
	  this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.42945F));
	  this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.57055F));
	  this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
	  this.tableLayoutPanel1.Size = new System.Drawing.Size(1279, 447);
	  this.tableLayoutPanel1.TabIndex = 0;
	  // 
	  // label1
	  // 
	  this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
	  this.label1.AutoSize = true;
	  this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	  this.label1.Location = new System.Drawing.Point(3, 11);
	  this.label1.Name = "label1";
	  this.label1.Size = new System.Drawing.Size(60, 17);
	  this.label1.TabIndex = 0;
	  this.label1.Text = "Pizzas:";
	  this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
	  // 
	  // label2
	  // 
	  this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
	  this.label2.AutoSize = true;
	  this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	  this.label2.Location = new System.Drawing.Point(476, 11);
	  this.label2.Name = "label2";
	  this.label2.Size = new System.Drawing.Size(94, 17);
	  this.label2.TabIndex = 1;
	  this.label2.Text = "Ingredients:";
	  // 
	  // label3
	  // 
	  this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
	  this.label3.AutoSize = true;
	  this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	  this.label3.Location = new System.Drawing.Point(1000, 11);
	  this.label3.Name = "label3";
	  this.label3.Size = new System.Drawing.Size(80, 17);
	  this.label3.TabIndex = 2;
	  this.label3.Text = "Toppings:";
	  // 
	  // _pizzaDataGridView
	  // 
	  this._pizzaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
	  this._pizzaDataGridView.AutoGenerateColumns = false;
	  this._pizzaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
	  this._pizzaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.EnergyValue,
            this.PurchasePrice,
            this.Vegetarian,
            this.retailPriceDataGridViewTextBoxColumn});
	  this._pizzaDataGridView.DataSource = this.pizzaBindingSource;
	  this._pizzaDataGridView.Location = new System.Drawing.Point(3, 43);
	  this._pizzaDataGridView.Name = "_pizzaDataGridView";
	  this._pizzaDataGridView.RowHeadersWidth = 25;
	  this._pizzaDataGridView.Size = new System.Drawing.Size(467, 338);
	  this._pizzaDataGridView.TabIndex = 3;
	  this._pizzaDataGridView.SelectionChanged += new System.EventHandler(this.PizzaDataGridViewSelectionChanged);
	  // 
	  // nameDataGridViewTextBoxColumn
	  // 
	  this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
	  this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
	  this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
	  this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
	  // 
	  // EnergyValue
	  // 
	  this.EnergyValue.DataPropertyName = "EnergyValue";
	  this.EnergyValue.HeaderText = "Energy Value";
	  this.EnergyValue.Name = "EnergyValue";
	  this.EnergyValue.ReadOnly = true;
	  this.EnergyValue.Width = 93;
	  // 
	  // PurchasePrice
	  // 
	  this.PurchasePrice.DataPropertyName = "PurchasePrice";
	  this.PurchasePrice.HeaderText = "Purchase Price";
	  this.PurchasePrice.Name = "PurchasePrice";
	  this.PurchasePrice.ReadOnly = true;
	  this.PurchasePrice.Width = 105;
	  // 
	  // Vegetarian
	  // 
	  this.Vegetarian.DataPropertyName = "Vegetarian";
	  this.Vegetarian.HeaderText = "Vegetarian";
	  this.Vegetarian.Name = "Vegetarian";
	  this.Vegetarian.ReadOnly = true;
	  this.Vegetarian.Width = 60;
	  // 
	  // retailPriceDataGridViewTextBoxColumn
	  // 
	  this.retailPriceDataGridViewTextBoxColumn.DataPropertyName = "RetailPrice";
	  this.retailPriceDataGridViewTextBoxColumn.HeaderText = "Retail Price";
	  this.retailPriceDataGridViewTextBoxColumn.Name = "retailPriceDataGridViewTextBoxColumn";
	  this.retailPriceDataGridViewTextBoxColumn.Width = 85;
	  // 
	  // pizzaBindingSource
	  // 
	  this.pizzaBindingSource.DataSource = typeof(PizzaDesigner.Pizza);
	  // 
	  // _ingredientDataGridView
	  // 
	  this._ingredientDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
	  this._ingredientDataGridView.AutoGenerateColumns = false;
	  this._ingredientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
	  this._ingredientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.servingSizeDataGridViewTextBoxColumn,
            this.energyValueDataGridViewTextBoxColumn,
            this.purchasePriceDataGridViewTextBoxColumn,
            this.vegetarianDataGridViewCheckBoxColumn});
	  this._ingredientDataGridView.DataSource = this.ingredientBindingSource;
	  this._ingredientDataGridView.Location = new System.Drawing.Point(476, 43);
	  this._ingredientDataGridView.Name = "_ingredientDataGridView";
	  this._ingredientDataGridView.RowHeadersWidth = 25;
	  this._ingredientDataGridView.Size = new System.Drawing.Size(518, 338);
	  this._ingredientDataGridView.TabIndex = 4;
	  this._ingredientDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.IngredientDataGridViewCellBeginEdit);
	  this._ingredientDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.IngredientDataGridViewCellEndEdit);
	  this._ingredientDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.IngredientDataGridViewDeletingRow);
	  // 
	  // nameDataGridViewTextBoxColumn1
	  // 
	  this.nameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
	  this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
	  this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
	  this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
	  // 
	  // servingSizeDataGridViewTextBoxColumn
	  // 
	  this.servingSizeDataGridViewTextBoxColumn.DataPropertyName = "ServingSize";
	  this.servingSizeDataGridViewTextBoxColumn.HeaderText = "Serving Size";
	  this.servingSizeDataGridViewTextBoxColumn.Name = "servingSizeDataGridViewTextBoxColumn";
	  this.servingSizeDataGridViewTextBoxColumn.Width = 95;
	  // 
	  // energyValueDataGridViewTextBoxColumn
	  // 
	  this.energyValueDataGridViewTextBoxColumn.DataPropertyName = "EnergyValue";
	  this.energyValueDataGridViewTextBoxColumn.HeaderText = "Energy Value";
	  this.energyValueDataGridViewTextBoxColumn.Name = "energyValueDataGridViewTextBoxColumn";
	  this.energyValueDataGridViewTextBoxColumn.Width = 95;
	  // 
	  // purchasePriceDataGridViewTextBoxColumn
	  // 
	  this.purchasePriceDataGridViewTextBoxColumn.DataPropertyName = "PurchasePrice";
	  this.purchasePriceDataGridViewTextBoxColumn.HeaderText = "Purchase Price";
	  this.purchasePriceDataGridViewTextBoxColumn.Name = "purchasePriceDataGridViewTextBoxColumn";
	  this.purchasePriceDataGridViewTextBoxColumn.Width = 108;
	  // 
	  // vegetarianDataGridViewCheckBoxColumn
	  // 
	  this.vegetarianDataGridViewCheckBoxColumn.DataPropertyName = "Vegetarian";
	  this.vegetarianDataGridViewCheckBoxColumn.HeaderText = "Vegetarian";
	  this.vegetarianDataGridViewCheckBoxColumn.Name = "vegetarianDataGridViewCheckBoxColumn";
	  this.vegetarianDataGridViewCheckBoxColumn.Width = 60;
	  // 
	  // ingredientBindingSource
	  // 
	  this.ingredientBindingSource.DataSource = typeof(PizzaDesigner.Ingredient);
	  // 
	  // _toppingsDataGridView
	  // 
	  this._toppingsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
	  this._toppingsDataGridView.AutoGenerateColumns = false;
	  this._toppingsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
	  this._toppingsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn2,
            this.ToppingServingSize,
            this.vegetarianDataGridViewCheckBoxColumn1});
	  this._toppingsDataGridView.DataSource = this.toppingBindingSource;
	  this._toppingsDataGridView.Location = new System.Drawing.Point(1000, 43);
	  this._toppingsDataGridView.Name = "_toppingsDataGridView";
	  this._toppingsDataGridView.RowHeadersWidth = 25;
	  this._toppingsDataGridView.Size = new System.Drawing.Size(276, 338);
	  this._toppingsDataGridView.TabIndex = 5;
	  this._toppingsDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.ToppingDataGridViewCellBeginEdit);
	  this._toppingsDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ToppingDataGridViewCellEndEdit);
	  this._toppingsDataGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.ToppingsDataGridViewUserDeletedRow);
	  this._toppingsDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.ToppingsDataGridViewDeletingRow);
	  // 
	  // nameDataGridViewTextBoxColumn2
	  // 
	  this.nameDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
	  this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
	  this.nameDataGridViewTextBoxColumn2.HeaderText = "Name";
	  this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
	  this.nameDataGridViewTextBoxColumn2.ReadOnly = true;
	  // 
	  // ToppingServingSize
	  // 
	  this.ToppingServingSize.DataPropertyName = "ToppingServingSize";
	  this.ToppingServingSize.HeaderText = "Serving Size";
	  this.ToppingServingSize.Name = "ToppingServingSize";
	  // 
	  // vegetarianDataGridViewCheckBoxColumn1
	  // 
	  this.vegetarianDataGridViewCheckBoxColumn1.DataPropertyName = "Vegetarian";
	  this.vegetarianDataGridViewCheckBoxColumn1.HeaderText = "Vegetarian";
	  this.vegetarianDataGridViewCheckBoxColumn1.Name = "vegetarianDataGridViewCheckBoxColumn1";
	  this.vegetarianDataGridViewCheckBoxColumn1.ReadOnly = true;
	  this.vegetarianDataGridViewCheckBoxColumn1.Width = 60;
	  // 
	  // toppingBindingSource
	  // 
	  this.toppingBindingSource.DataSource = typeof(PizzaDesigner.Topping);
	  // 
	  // _addToppingButton
	  // 
	  this._addToppingButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
	  this._addToppingButton.Cursor = System.Windows.Forms.Cursors.Hand;
	  this._addToppingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	  this._addToppingButton.Location = new System.Drawing.Point(476, 387);
	  this._addToppingButton.Name = "_addToppingButton";
	  this._addToppingButton.Size = new System.Drawing.Size(518, 57);
	  this._addToppingButton.TabIndex = 6;
	  this._addToppingButton.Text = "Add Topping";
	  this._addToppingButton.UseVisualStyleBackColor = true;
	  this._addToppingButton.Click += new System.EventHandler(this.AddToppingButtonClick);
	  // 
	  // _MenuButton
	  // 
	  this._MenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
	  this._MenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	  this._MenuButton.Location = new System.Drawing.Point(3, 387);
	  this._MenuButton.Name = "_MenuButton";
	  this._MenuButton.Size = new System.Drawing.Size(467, 57);
	  this._MenuButton.TabIndex = 7;
	  this._MenuButton.Text = "Menu";
	  this._MenuButton.UseVisualStyleBackColor = true;
	  this._MenuButton.Click += new System.EventHandler(this.MenuButtonClick);
	  // 
	  // PizzaDesignerForm
	  // 
	  this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
	  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	  this.ClientSize = new System.Drawing.Size(1281, 450);
	  this.Controls.Add(this.tableLayoutPanel1);
	  this.Name = "PizzaDesignerForm";
	  this.Text = "Pizza Designer";
	  this.tableLayoutPanel1.ResumeLayout(false);
	  this.tableLayoutPanel1.PerformLayout();
	  ((System.ComponentModel.ISupportInitialize)(this._pizzaDataGridView)).EndInit();
	  ((System.ComponentModel.ISupportInitialize)(this.pizzaBindingSource)).EndInit();
	  ((System.ComponentModel.ISupportInitialize)(this._ingredientDataGridView)).EndInit();
	  ((System.ComponentModel.ISupportInitialize)(this.ingredientBindingSource)).EndInit();
	  ((System.ComponentModel.ISupportInitialize)(this._toppingsDataGridView)).EndInit();
	  ((System.ComponentModel.ISupportInitialize)(this.toppingBindingSource)).EndInit();
	  this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView _pizzaDataGridView;
		private System.Windows.Forms.DataGridView _ingredientDataGridView;
		private System.Windows.Forms.DataGridView _toppingsDataGridView;
		private System.Windows.Forms.BindingSource pizzaBindingSource;
		private System.Windows.Forms.BindingSource ingredientBindingSource;
		private System.Windows.Forms.Button _addToppingButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn servingSizeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn energyValueDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn purchasePriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn vegetarianDataGridViewCheckBoxColumn;
		private System.Windows.Forms.Button _MenuButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn EnergyValue;
		private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePrice;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Vegetarian;
		private System.Windows.Forms.DataGridViewTextBoxColumn retailPriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource toppingBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn ToppingServingSize;
		private System.Windows.Forms.DataGridViewCheckBoxColumn vegetarianDataGridViewCheckBoxColumn1;
	}
}

