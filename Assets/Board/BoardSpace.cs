using UnityEngine;
using System.Collections;

public abstract class BoardSpace : MonoBehaviour {
	
	//offset from board
	public Vector3 offset;
	
	// Use this for initialization
	void Start () {
	
	}
	
	/// <summary>
	/// behavior that happens when you land here
	/// </summary>
	public abstract void Land();
}
