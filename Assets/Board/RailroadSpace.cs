using UnityEngine;
using System.Collections;

public class RailroadSpace : BoardSpace {

	// Use this for initialization
	void Start () {
	
	}
	
	/// <summary>
	/// buy a railroad / pay
	/// </summary>
	public override void Land ()
	{
		Debug.Log("Railroad space!");
	}
}
