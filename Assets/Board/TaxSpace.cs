using UnityEngine;
using System.Collections;

public class TaxSpace : BoardSpace {
	int fee;

	public int Fee
	{
		get { return fee; }
		set { fee = value; }
	}

	/// <summary>
	/// pay FEES
	/// </summary>
	public override void Land ()
	{
		Debug.Log("Tax space! Fee: $" + fee);
	}
}
