using UnityEngine;
using System.Collections;

public class TaxSpace : BoardSpace {
	/// <summary>
	/// pay FEES
	/// </summary>
	public override void Land ()
	{
		Debug.Log("Tax space!");
	}
}
