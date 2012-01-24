using System;
using UnityEngine;

//helper class with simple common static methods
public class Helper
{
	/// <summary>
	/// shows or hides a game object AND all its children
	/// </summary>
	/// <param name="obj">
	/// A <see cref="GameObject"/> whose self plus children shall be shown/hidden
	/// </param>
	/// <param name="show">
	/// A <see cref="System.Boolean"/> : true = show, false = hide
	/// </param>
	public static void ShowOrHide(GameObject obj, bool show)
	{
		foreach (Renderer r in obj.GetComponentsInChildren(typeof(Renderer)))
		{
			r.enabled = show;
		}
	}
}
