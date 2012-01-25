using UnityEngine;
using System.Collections;

public class JailSpace : BoardSpace
{
	/// <summary>
	/// go to jail
	/// </summary>
	public override void Land ()
	{
		Debug.Log("Jail space!");
	}
}
