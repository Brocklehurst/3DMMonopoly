using UnityEngine;
using System.Collections;

//represents a single player in the game
public class Player
{
	int money;
	int railroads;
	int utilities;
	int lastDiceRoll;

	public Player()
	{
		railroads = 0;
		utilities = 0;
		lastDiceRoll = 0;
	}

	#region properties
	public int Railroads
	{
		get { return railroads; }
	}
	public int Utilities
	{
		get { return utilities; }
	}
	public int LastDiceRoll
	{
		get { return lastDiceRoll; }
		set { lastDiceRoll = value; }
	}
	#endregion
}
