using UnityEngine;
using System.Collections;

public class GoSpace : BoardSpace {
	/// <summary>
	/// land on go, collect extra!
	/// </summary>
	public override void Land ()
	{
		Debug.Log("Go space!");
	}
}
