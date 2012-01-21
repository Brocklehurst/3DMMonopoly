using UnityEngine;
using System.Collections;

public class SurpriseSpace : BoardSpace {

	// Use this for initialization
	void Start () {
	
	}
	
	/// <summary>
	/// shows a surprise card
	/// </summary>
	public override void Land ()
	{
		Debug.Log("Surprise space!");
	}
}
