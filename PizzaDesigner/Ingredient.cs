using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDesigner
{
  class Ingredient : INotifyPropertyChanged
  {
	private string _name;
	private decimal _servingSize;
	private decimal _energyValue;
	private decimal _purchasePrice;
	private bool _vegetarian;
	public event PropertyChangedEventHandler PropertyChanged;

	public Ingredient() : this("", 0, 0, 0, false)
	{
	}

	public Ingredient(string name, decimal servingSize, decimal energyValue, decimal purchasePrice, bool vegetarian)
	{
	  _name = name;
	  _servingSize = servingSize;
	  _energyValue = energyValue;
	  _purchasePrice = purchasePrice;
	  _vegetarian = vegetarian;
	}

	protected void FirePropertyChanged(string property)
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
		if (_name != value)
		{
		  _name = value;
		  FirePropertyChanged("Name");
		}
	  }
	}

	public decimal ServingSize
	{
	  get
	  {
		return _servingSize;
	  }
	  set
	  {
		if (_servingSize != value)
		{
		  _servingSize = value;
		  FirePropertyChanged("ServingSize");
		}
	  }
	}

	public decimal EnergyValue
	{
	  get
	  {
		return _energyValue;
	  }
	  set
	  {
		if (_energyValue != value)
		{
		  _energyValue = value;
		  FirePropertyChanged("EnergyValue");
		}
	  }
	}

	public decimal PurchasePrice
	{
	  get
	  {
		return _purchasePrice;
	  }
	  set
	  {
		if (_purchasePrice != value)
		{
		  _purchasePrice = value;
		  FirePropertyChanged("PurchasePrice");
		}
	  }
	}
	public bool Vegetarian
	{
	  get
	  {
		return _vegetarian;
	  }
	  set
	  {
		if (_vegetarian != value)
		{
		  _vegetarian = value;
		  FirePropertyChanged("Vegetarian");
		}
	  }
	}

  }
}
