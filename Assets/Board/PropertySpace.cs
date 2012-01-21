using UnityEngine;
using System.Collections;

public class PropertySpace : BoardSpace {

	// Use this for initialization
	void Start () {
	
	}
	
	/// <summary>
	/// buy a property / pay
	/// </summary>
	public override void Land ()
	{
		Debug.Log("Property space!");
	}
}
