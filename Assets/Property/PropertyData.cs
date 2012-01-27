using System.Collections.Generic;
using System;

//contains data about properties
public class PropertyData
{
	//mapping from player to property
	List<Pair<Property, Player>> ownership;
	const int propertyAmount = 28;

	public PropertyData()
	{
		ownership = new List<Pair<Property, Player>>();
		//fill in initial blank pairs too
		for (int i = 0; i < propertyAmount; i++)
		{
			ownership.Add(new Pair<Property, Player>(null, null));
		}
	}

	public List<Pair<Property, Player>> OwnershipTable
	{
		get { return ownership; }
	}

	/// <summary>
	/// updates the ownership mapping with a particular property
	/// </summary>
	/// <param name="propNum">
	/// An index into the ownership mapping
	/// </param>
	/// <param name="p">
	/// A <see cref="Property"/> to update at that spot
	/// </param>
	public void SetProperty(int propNum, Property p)
	{
		ownership[propNum].First = p;
	}

	/// <summary>
	/// updates the ownership mapping with a particular player
	/// </summary>
	/// <param name="propNum">
	/// An index into the ownership mapping
	/// </param>
	/// <param name="p">
	/// A <see cref="Player"/> to update at that spot
	/// </param>
	public void SetPlayer(int propNum, Player p)
	{
		ownership[propNum].Second = p;
	}
}
