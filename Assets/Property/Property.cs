using UnityEngine;
using System.Collections;

//represents a single property to be purchased
public abstract class Property
{
	int price;
	int mortgageValue;
	bool mortgaged;

	public Property(int p, int mort)
	{
		price = p;
		mortgageValue = mort;
		mortgaged = false;
	}

	public int MortgageValue
	{
		get { return mortgageValue; }
	}

	/// <summary>
	/// calculates total fine to be charged when landing here
	/// </summary>
	/// <param name="p">
	/// A <see cref="Player"/> who lands here
	/// </param>
	/// <returns>
	/// total fine
	/// </returns>
	public abstract int CalculateFine(Player p);
}
