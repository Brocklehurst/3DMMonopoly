using UnityEngine;
using System.Collections;

public class PropertySpace : BoardSpace
{
	Property property;

	//create and set the property mapping
	public void SetProperty(int propNum, Property p)
	{
		property = p;
		PropertyData pi = Helper.GameData.properties;
		pi.SetProperty(propNum, property);
	}
	
	/// <summary>
	/// buy a property / pay
	/// </summary>
	public override void Land ()
	{
		Debug.Log("Property space! Fine: $" + property.CalculateFine(new Player()));
	}
}
