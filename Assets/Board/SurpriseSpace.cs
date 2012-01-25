using UnityEngine;
using System.Collections;

public class SurpriseSpace : BoardSpace {
	/// <summary>
	/// shows a surprise card
	/// </summary>
	public override void Land ()
	{
		Debug.Log("Surprise space!");
	}
}
