using UnityEngine;
using System.Collections;

public abstract class BoardSpace
{
	//offset from board
	public Vector3 offset;
	
	/// <summary>
	/// behavior that happens when you land here
	/// </summary>
	public abstract void Land();
}
