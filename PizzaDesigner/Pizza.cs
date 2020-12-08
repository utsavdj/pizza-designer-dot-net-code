using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace PizzaDesigner
{
  class Pizza : INotifyPropertyChanged
  {
	private string _name;
	private decimal _retailPrice;
	private decimal _energyValue;
	private decimal _purchasePrice;
	private decimal _initialToppingEnergyValue;
	private decimal _initialToppingPurchasePrice;
	private BindingList<Topping> _toppings;
	public event PropertyChangedEventHandler PropertyChanged;

	public Pizza() : this("", 0)
	{
	}

	public Pizza(string name, decimal retailPrice)
	{
	  _name = name;
	  _retailPrice = retailPrice;
	  _toppings = new BindingList<Topping>();

	  _toppings.ListChanged += new ListChangedEventHandler(ToppingListChanged);
	}

	public void AddTopping(Ingredient ingredient)
	{
	  if (_toppings.Count > 0)
	  {
		foreach (Topping topping in _toppings)
		{
		  if (topping.Name == ingredient.Name)
		  {
			MessageBox.Show("This topping has already been added, please choose a different topping.",
			  "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
			return;
		  }
		}
	  }
	  Topping newTopping = new Topping(ingredient);
	  _toppings.Add(newTopping);
	  _energyValue += newTopping.ToppingEnergyValue;
	  _purchasePrice += newTopping.ToppingPurchasePrice;
	}

	public void RemoveIngredient(Ingredient ingredient)
	{
	  foreach (Topping topping in _toppings)
	  {
		if (topping.Name == ingredient.Name)
		{
		  _energyValue -= topping.ToppingEnergyValue;
		  _purchasePrice -= topping.ToppingPurchasePrice;
		  _toppings.Remove(topping);
		  return;
		}
	  }
	}

	public void RemoveTopping(int toppingIndex)
	{
	  if (toppingIndex >= 0 && toppingIndex < _toppings.Count)
	  {
		_energyValue -= _toppings[toppingIndex].ToppingEnergyValue;
		_purchasePrice -= _toppings[toppingIndex].ToppingPurchasePrice;
	  }
	}

	public bool UpdateToppingValues(Ingredient ingredient, string initialIngredientName)
	{
	  foreach (Topping topping in _toppings)
	  {
		if (topping.Name == ingredient.Name)
		{
		  if (topping.EnergyValue != ingredient.EnergyValue)
		  {
			_energyValue -= topping.ToppingEnergyValue;
			topping.EnergyValue = ingredient.EnergyValue;
			_energyValue += topping.ToppingEnergyValue;
			return true;
		  }
		  else if (topping.PurchasePrice != ingredient.PurchasePrice)
		  {
			_purchasePrice -= topping.ToppingPurchasePrice;
			topping.PurchasePrice = ingredient.PurchasePrice;
			_purchasePrice += topping.ToppingPurchasePrice;
			return true;
		  }
		  else if (topping.Vegetarian != ingredient.Vegetarian)
		  {
			topping.Vegetarian = ingredient.Vegetarian;
			return true;
		  }
		  else if (topping.ServingSize != ingredient.ServingSize)
		  {
			_energyValue -= topping.ToppingEnergyValue;
			_purchasePrice -= topping.ToppingPurchasePrice;
			topping.ServingSize = ingredient.ServingSize;
			_energyValue += topping.ToppingEnergyValue;
			_purchasePrice += topping.ToppingPurchasePrice;
			return true;
		  }
		}
		else if (topping.Name == initialIngredientName)
		{
		  topping.Name = ingredient.Name;
		  return true;
		}
	  }
	  return false;
	}

	public bool IsVegetarian()
	{
	  foreach (Topping topping in _toppings)
	  {
		if (!topping.Vegetarian)
		{
		  return false;
		}
	  }
	  return true;
	}

	public string GetToppings()
	{
	  List<string> toppingList = new List<string>();
	  foreach (Topping topping in _toppings)
	  {
		if (!toppingList.Contains(topping.Name))
		{
		  toppingList.Add(topping.Name);
		}
	  }
	  string toppings = string.Join(", ", toppingList);
	  return toppings;
	}

	public void BindToppings(DataGridView dataGridView)
	{
	  dataGridView.DataSource = _toppings;
	}

	private void ToppingListChanged(object sender, ListChangedEventArgs e)
	{
	  FirePropertyChanged("EnergyValue");
	  FirePropertyChanged("PurchasePrice");
	  FirePropertyChanged("Vegetarian");
	}

	public void UpdatePizzaValues(int index)
	{
	  _energyValue -= _initialToppingEnergyValue;
	  _purchasePrice -= _initialToppingPurchasePrice;

	  _energyValue += _toppings[index].ToppingEnergyValue;
	  _purchasePrice += _toppings[index].ToppingPurchasePrice;
	}

	public void SetToppingInitialValues(int index)
	{
	  _initialToppingEnergyValue = _toppings[index].ToppingEnergyValue;
	  _initialToppingPurchasePrice = _toppings[index].ToppingPurchasePrice;
	}

	private void FirePropertyChanged(string property)
	{
	  if (PropertyChanged != null)
	  {
		PropertyChanged(this, new PropertyChangedEventArgs(property));
	  }
	}

	public string Name
	{
	  get
	  {
		return _name;
	  }
	  set
	  {
		_name = value;
	  }
	}

	public decimal EnergyValue
	{
	  get
	  {
		return _energyValue;
	  }
	}

	public decimal PurchasePrice
	{
	  get
	  {
		return _purchasePrice;
	  }
	}

	public bool Vegetarian
	{
	  get
	  {
		return IsVegetarian();
	  }
	}

	public decimal RetailPrice
	{
	  get
	  {
		return _retailPrice;
	  }
	  set
	  {
		_retailPrice = value;
	  }
	}

  }
}
