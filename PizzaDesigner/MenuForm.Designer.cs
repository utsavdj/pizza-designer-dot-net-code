namespace PizzaDesigner
{
  partial class MenuForm
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
	  this.label1 = new System.Windows.Forms.Label();
	  this._vegetarianPizzaListBox = new System.Windows.Forms.ListBox();
	  this.label2 = new System.Windows.Forms.Label();
	  this._nonVegetarianPizzaListBox = new System.Windows.Forms.ListBox();
	  this.pizzaBindingSource = new System.Windows.Forms.BindingSource(this.components);
	  ((System.ComponentModel.ISupportInitialize)(this.pizzaBindingSource)).BeginInit();
	  this.SuspendLayout();
	  // 
	  // label1
	  // 
	  this.label1.AutoSize = true;
	  this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	  this.label1.Location = new System.Drawing.Point(12, 9);
	  this.label1.Name = "label1";
	  this.label1.Size = new System.Drawing.Size(144, 17);
	  this.label1.TabIndex = 0;
	  this.label1.Text = "Vegetarian Pizzas:";
	  // 
	  // _vegetarianPizzaListBox
	  // 
	  this._vegetarianPizzaListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
	  this._vegetarianPizzaListBox.FormattingEnabled = true;
	  this._vegetarianPizzaListBox.Location = new System.Drawing.Point(15, 29);
	  this._vegetarianPizzaListBox.Name = "_vegetarianPizzaListBox";
	  this._vegetarianPizzaListBox.Size = new System.Drawing.Size(637, 201);
	  this._vegetarianPizzaListBox.TabIndex = 1;
	  this._vegetarianPizzaListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.VegetarianPizzaListBoxDrawItem);
	  this._vegetarianPizzaListBox.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.VegetarianPizzaListBoxMeasureItem);
	  // 
	  // label2
	  // 
	  this.label2.AutoSize = true;
	  this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	  this.label2.Location = new System.Drawing.Point(12, 238);
	  this.label2.Name = "label2";
	  this.label2.Size = new System.Drawing.Size(177, 17);
	  this.label2.TabIndex = 2;
	  this.label2.Text = "Non-vegetarian Pizzas:";
	  // 
	  // _nonVegetarianPizzaListBox
	  // 
	  this._nonVegetarianPizzaListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
	  this._nonVegetarianPizzaListBox.FormattingEnabled = true;
	  this._nonVegetarianPizzaListBox.Location = new System.Drawing.Point(15, 258);
	  this._nonVegetarianPizzaListBox.Name = "_nonVegetarianPizzaListBox";
	  this._nonVegetarianPizzaListBox.Size = new System.Drawing.Size(637, 201);
	  this._nonVegetarianPizzaListBox.TabIndex = 3;
	  this._nonVegetarianPizzaListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.NonVegetarianPizzaListBoxDrawItem);
	  this._nonVegetarianPizzaListBox.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.NonVegetarianPizzaListBoxMeasureItem);
	  // 
	  // pizzaBindingSource
	  // 
	  this.pizzaBindingSource.DataSource = typeof(PizzaDesigner.Pizza);
	  // 
	  // MenuForm
	  // 
	  this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
	  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	  this.ClientSize = new System.Drawing.Size(664, 473);
	  this.Controls.Add(this._nonVegetarianPizzaListBox);
	  this.Controls.Add(this.label2);
	  this.Controls.Add(this._vegetarianPizzaListBox);
	  this.Controls.Add(this.label1);
	  this.Name = "MenuForm";
	  this.Text = "Menu";
	  ((System.ComponentModel.ISupportInitialize)(this.pizzaBindingSource)).EndInit();
	  this.ResumeLayout(false);
	  this.PerformLayout();

	}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.BindingSource pizzaBindingSource;
		private System.Windows.Forms.ListBox _vegetarianPizzaListBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox _nonVegetarianPizzaListBox;
	}
}