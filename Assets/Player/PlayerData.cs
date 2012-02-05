using UnityEngine;
using System.Collections.Generic;

public class PlayerData
{
    List<Player> players;
	int current;

    public PlayerData()
    {
		current = 0;
        players = new List<Player>();
        players.Add(new Player(GameObject.Find("Bullhorncar1").GetComponent<MovePiece>(), ""));
		players.Add(new Player(GameObject.Find("Bullhorncar2").GetComponent<MovePiece>(), ""));
		players.Add(new Player(GameObject.Find("Bullhorncar3").GetComponent<MovePiece>(), ""));
		players.Add(new Player(GameObject.Find("Bullhorncar4").GetComponent<MovePiece>(), ""));
    }

    public Player Get(int num)
    {
        return players[num];
    }

	public Player Current
	{
		get { return players[current]; }
	}

	/// <summary>
	/// next player's turn
	/// </summary>
	public void NextTurn()
	{
		current = (current + 1) % players.Count;
	}

	/// <summary>
	/// point camera to current player
	/// </summary>
	public void CameraToCurrent()
	{
		GameObject.Find("Main Camera").GetComponent<SmoothFollow>().target = Current.Piece;
	}
}
