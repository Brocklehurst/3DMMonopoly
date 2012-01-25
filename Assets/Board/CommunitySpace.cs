using UnityEngine;
using System.Collections;

public class CommunitySpace : BoardSpace
{
	/// <summary>
	/// show 3DMM Community Chest card
	/// </summary>
	public override void Land ()
	{
		TakeCard card = GameObject.Find("CommunityCard").GetComponent<TakeCard>();
		card.Take();
	}
}
