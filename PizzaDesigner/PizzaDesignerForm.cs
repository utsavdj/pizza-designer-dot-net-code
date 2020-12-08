using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaDesigner
{
  public partial class PizzaDesignerForm : Form
  {
	private BindingList<Pizza> _pizzas;
	private BindingList<Ingredient> _ingredients;
	private string initialIngredientName;
	private MenuForm _menuForm;

	public PizzaDesignerForm()
	{
	  InitializeComponent();
	  _pizzas = new BindingList<Pizza>();
	  _ingredients = new BindingList<Ingredient>();

	  AddIngredients();

	  _ingredientDataGridView.DataSource = _ingredients;

	  _pizzas.Add(new Pizza("Margherita", 16.00M));
	  _pizzas.Add(new Pizza("Marinara", 16.00M));
	  _pizzas.Add(new Pizza("Napoli", 18.00M));
	  _pizzas.Add(new Pizza("Capricciosa", 18.00M));
	  _pizzas.Add(new Pizza("Calzone", 20.00M));
	  _pizzas.Add(new Pizza("Meat Lovers", 20.00M));
	  _pizzas.Add(new Pizza("Hawaiian", 18.00M));
	  _pizzaDataGridView.DataSource = _pizzas;

	  Ingredient pineapple = _ingredients[12];
	  Ingredient anchovies = _ingredients[0];
	  Ingredient ham = _ingredients[7];
	  Ingredient salami = _ingredients[14];
	  Ingredient chickenBreast = _ingredients[4];
	  Ingredient tomatoSauce = _ingredients[18];
	  Ingredient mozzarella = _ingredients[8];
	  Ingredient thickBase = _ingredients[16];
	  Ingredient thinBase = _ingredients[17];

	  Pizza hawaiian = _pizzas[6];
	  hawaiian.AddTopping(pineapple);
	  hawaiian.AddTopping(ham);
	  hawaiian.AddTopping(tomatoSauce);
	  hawaiian.AddTopping(mozzarella);
	  hawaiian.AddTopping(thickBase);

	  Pizza margherita = _pizzas[0];
	  margherita.AddTopping(tomatoSauce);
	  margherita.AddTopping(mozzarella);
	  margherita.AddTopping(thickBase);

	  Pizza meatLovers = _pizzas[5];
	  meatLovers.AddTopping(ham);
	  meatLovers.AddTopping(salami);
	  meatLovers.AddTopping(chickenBreast);
	  meatLovers.AddTopping(tomatoSauce);
	  meatLovers.AddTopping(mozzarella);
	  meatLovers.AddTopping(thickBase);

	  Pizza napoli = _pizzas[2];
	  napoli.AddTopping(anchovies);
	  napoli.AddTopping(tomatoSauce);
	  napoli.AddTopping(mozzarella);
	  napoli.AddTopping(thinBase);

	  _toppingsDataGridView.AllowUserToAddRows = false;
	}

	private void AddIngredients()
	{
	  try
	  {
		string ingredientsFilePath = Path.Combine(Directory.GetCurrentDirectory(), "../../ingredients.csv");
		string[] lines = System.IO.File.ReadAllLines(ingredientsFilePath);
		if (lines.Length > 0)
		{
		  for (var i = 1; i < lines.Length; i++)
		  {
			string[] fields = lines[i].Split(',');
			string name = fields[0];
			decimal servingSize = Convert.ToDecimal(fields[1]);
			decimal energyValue = Convert.ToDecimal(fields[2]);
			decimal purchasePrice = Convert.ToDecimal(fields[3]);
			bool vegetarian = Convert.ToBoolean(fields[4]);
			_ingredients.Add(new Ingredient(name, servingSize, energyValue, purchasePrice, vegetarian));
		  }
		}
	  }
	  catch (Exception e)
	  {
		Console.WriteLine("The ingredients csv file could not be read:");
		Console.WriteLine(e.Message);
	  }
	}

	private void PizzaDataGridViewSelectionChanged(object sender, EventArgs e)
	{
	  DataGridViewCell cell = _pizzaDataGridView.CurrentCell;
	  if (cell != null)
	  {
		int index = cell.RowIndex;
		Pizza pizza = _pizzas[index];
		pizza.BindToppings(_toppingsDataGridView);
	  }
	}

	private void AddToppingButtonClick(object sender, EventArgs e)
	{
	  DataGridViewCell pizzaCell = _pizzaDataGridView.CurrentCell;
	  if (pizzaCell == null)
	  {
		MessageBox.Show("No pizza is selected.");
		return;
	  }

	  DataGridViewCell ingridentCell = _ingredientDataGridView.CurrentCell;
	  if (ingridentCell == null)
	  {
		MessageBox.Show("No ingrident is selected");
		return;
	  }

	  int pizzaIndex = pizzaCell.RowIndex;
	  Pizza pizza = _pizzas[pizzaIndex];

	  int ingredientIndex = ingridentCell.RowIndex;
	  Ingredient ingredient = _ingredients[ingredientIndex];

	  pizza.AddTopping(ingredient);
	  if (_menuForm != null)
	  {
		UpdateMenu();
	  }
	}

	private void IngredientDataGridViewDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
	{
	  int index = e.Row.Index;
	  Ingredient ingredient = _ingredients[index];
	  foreach (Pizza pizza in _pizzas)
	  {
		pizza.RemoveIngredient(ingredient);
	  }
	}

	private void ToppingsDataGridViewDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
	{
	  int toppingIndex = e.Row.Index;
	  DataGridViewCell pizzaCell = _pizzaDataGridView.CurrentCell;
	  if (pizzaCell != null)
	  {
		int pizzaIndex = pizzaCell.RowIndex;
		Pizza pizza = _pizzas[pizzaIndex];
		pizza.RemoveTopping(toppingIndex);
	  }
	}

	private void ToppingsDataGridViewUserDeletedRow(object sender, DataGridViewRowEventArgs e)
	{
	  if (_menuForm != null)
	  {
		UpdateMenu();
	  }
	}

	private void MenuButtonClick(object sender, EventArgs e)
	{
	  if (!IsFormOpen("MenuForm"))
	  {
		_menuForm = new MenuForm(GetMenuItems());
		_menuForm.Show();
	  }
	}

	// The following code was copied from https://www.codeproject.com/Questions/369414/How-to-check-whether-one-from-is-already-open-or-n
	public bool IsFormOpen(string formName)
	{
	  foreach (Form form in Application.OpenForms)
		if (form.GetType().Name == formName)
		  return true;
	  return false;
	}
	// End of copied code

	private BindingList<Tuple<string, bool>> GetMenuItems()
	{
	  BindingList<Tuple<string, bool>> pizzas = new BindingList<Tuple<string, bool>>();
	  foreach (Pizza pizza in _pizzas)
	  {
		pizzas.Add(new Tuple<string, bool>(pizza.Name + " ----- $" + pizza.RetailPrice +
		  (pizza.GetToppings() != "" ? "\nIngredients: " + pizza.GetToppings() : ""), pizza.Vegetarian));
	  }
	  return pizzas;
	}

	private void UpdateMenu()
	{
	  _menuForm.UpdateMenu(GetMenuItems());
	}

	private void IngredientDataGridViewCellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
	{
	  IngredientCellEdit(false);
	}

	private void IngredientDataGridViewCellEndEdit(object sender, DataGridViewCellEventArgs e)
	{
	  IngredientCellEdit(true);
	}

	private void IngredientCellEdit(bool isCellEndEdit)
	{
	  DataGridViewCell ingridentCell = _ingredientDataGridView.CurrentCell;
	  if (ingridentCell == null)
	  {
		MessageBox.Show("No ingrident is selected");
		return;
	  }
	  int ingredientIndex = ingridentCell.RowIndex;
	  if (isCellEndEdit)
	  {
		Ingredient ingredient = _ingredients[ingredientIndex];
		foreach (Pizza pizza in _pizzas)
		{
		  if (pizza.UpdateToppingValues(ingredient, initialIngredientName) && _menuForm != null)
		  {
			UpdateMenu();
		  }
		}
	  }
	  else
	  {
		initialIngredientName = _ingredients[ingredientIndex].Name;
	  }
	}

	private void ToppingDataGridViewCellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
	{
	  ToppingCellEdit(false);
	}

	private void ToppingDataGridViewCellEndEdit(object sender, DataGridViewCellEventArgs e)
	{
	  ToppingCellEdit(true);
	}

	private void ToppingCellEdit(bool isCellEndEdit)
	{
	  DataGridViewCell pizzaCell = _pizzaDataGridView.CurrentCell;
	  if (pizzaCell != null)
	  {
		DataGridViewCell toppingCell = _toppingsDataGridView.CurrentCell;
		if (toppingCell == null)
		{
		  MessageBox.Show("No ingrident is selected");
		  return;
		}

		int pizzaIndex = pizzaCell.RowIndex;
		Pizza pizza = _pizzas[pizzaIndex];

		int toppingIndex = toppingCell.RowIndex;

		if (isCellEndEdit)
		{
		  pizza.UpdatePizzaValues(toppingIndex);
		}
		else
		{
		  pizza.SetToppingInitialValues(toppingIndex);
		}
	  }
	}

  }
}
