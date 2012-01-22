using UnityEngine;
using System.Collections;

public class GoSpace : BoardSpace {

	// Use this for initialization
	void Start () {
	}
	
	/// <summary>
	/// land on go, collect extra!
	/// </summary>
	public override void Land ()
	{
		Debug.Log("Go space!");
	}
}
