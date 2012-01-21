using UnityEngine;
using System.Collections;

public class TaxSpace : BoardSpace {

	// Use this for initialization
	void Start () {
	
	}
	
	/// <summary>
	/// pay FEES
	/// </summary>
	public override void Land ()
	{
		Debug.Log("Tax space!");
	}
}
