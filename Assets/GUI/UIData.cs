using UnityEngine;
using System.Collections.Generic;

//holds a bit of information about the UI
public class UIData
{
	private List<GameObject> disabled;
	
	public UIData()
	{
		disabled = new List<GameObject>();
	}
	
	/// <summary>
	/// Temporarily disables the UI piece.
	/// </summary>
	/// <param name='o'>
	/// object to disable
	/// </param>
	public void DisablePiece(GameObject o)
	{
		//add to temp list
		disabled.Add(o);
		o.active = false;
	}
	
	/// <summary>
	/// Reenable the UI pieces
	/// </summary>
	public void Reenable()
	{
		disabled.ForEach((o) => { o.active = true; });
		disabled.Clear();
	}
}
