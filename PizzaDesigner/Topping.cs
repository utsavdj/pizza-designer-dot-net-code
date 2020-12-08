using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDesigner
{
  class Topping : Ingredient
  {
	private decimal _servingSize;

	public Topping(Ingredient ingredient)
	{
	  Name = ingredient.Name;
	  _servingSize = ingredient.ServingSize;
	  ServingSize = ingredient.ServingSize;
	  EnergyValue = ingredient.EnergyValue;
	  PurchasePrice = ingredient.PurchasePrice;
	  Vegetarian = ingredient.Vegetarian;
	}

	public decimal ToppingServingSize
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
		  FirePropertyChanged("ToppingServingSize");
		}
	  }
	}

	public decimal ToppingEnergyValue
	{
	  get
	  {
		return Math.Round((_servingSize / ServingSize) * EnergyValue, 2);
	  }
	}

	public decimal ToppingPurchasePrice
	{
	  get
	  {
		return Math.Round((_servingSize / ServingSize) * PurchasePrice, 2);
	  }
	}

  }
}
