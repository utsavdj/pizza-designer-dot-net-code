using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaDesigner
{
  public partial class MenuForm : Form
  {
	private BindingList<string> _vegetarianPizzas;
	private BindingList<string> _nonVegetarianPizzas;
	private const int ITEM_MARGIN = 10;

	public MenuForm(BindingList<Tuple<string, bool>> pizzas)
	{
	  InitializeComponent();

	  UpdateMenu(pizzas);
	  _vegetarianPizzaListBox.ClearSelected();
	  _nonVegetarianPizzaListBox.ClearSelected();
	}

	public void UpdateMenu(BindingList<Tuple<string, bool>> pizzas)
	{
	  _vegetarianPizzas = new BindingList<string>();
	  _nonVegetarianPizzas = new BindingList<string>();
	  foreach (Tuple<string, bool> pizza in pizzas)
	  {
		string text = pizza.Item1;
		if (pizza.Item2)
		{
		  _vegetarianPizzas.Add(text);
		}
		else
		{
		  _nonVegetarianPizzas.Add(text);
		}
	  }
	  _vegetarianPizzaListBox.DataSource = _vegetarianPizzas;
	  _nonVegetarianPizzaListBox.DataSource = _nonVegetarianPizzas;
	}

	private void VegetarianPizzaListBoxDrawItem(object sender, DrawItemEventArgs e)
	{
	  DrawItem(e, true);
	}

	private void VegetarianPizzaListBoxMeasureItem(object sender, MeasureItemEventArgs e)
	{
	  MeasureItem(e, true);
	}

	private void NonVegetarianPizzaListBoxDrawItem(object sender, DrawItemEventArgs e)
	{
	  DrawItem(e, false);
	}

	private void NonVegetarianPizzaListBoxMeasureItem(object sender, MeasureItemEventArgs e)
	{
	  MeasureItem(e, false);
	}

	private void DrawItem(DrawItemEventArgs e, bool vegetarian)
	{
	  e.DrawBackground();
	  e.DrawFocusRectangle();
	  int index = e.Index;
	  if (index >= 0)
	  {
		string pizza;
		Font font;
		if (vegetarian)
		{
		  pizza = _vegetarianPizzas[index];
		  font = _vegetarianPizzaListBox.Font;
		}
		else
		{
		  pizza = _nonVegetarianPizzas[index];
		  font = _nonVegetarianPizzaListBox.Font;
		}
		Brush brush = new SolidBrush(e.ForeColor);
		Graphics graphics = e.Graphics;

		graphics.DrawString(pizza, font, brush, e.Bounds.Left, e.Bounds.Top + ITEM_MARGIN);
	  }
	}

	// The following code was copied from http://csharphelper.com/blog/2014/11/make-an-owner-drawn-listbox-in-c/
	private void MeasureItem(MeasureItemEventArgs e, bool vegetarian)
	{
	  int index = e.Index;

	  if (index >= 0)
	  {
		string pizza;
		if (vegetarian)
		{
		  pizza = _vegetarianPizzas[index];
		}
		else
		{
		  pizza = _nonVegetarianPizzas[index];
		}
		SizeF text_size = e.Graphics.MeasureString(pizza, this.Font);

		e.ItemHeight = (int)text_size.Height + (2 * ITEM_MARGIN);
	  }
	}
	// End of copied code

  }
}
