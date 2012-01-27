using UnityEngine;
using System.Collections.Generic;

public class PlayerData
{
    List<Player> players;

    public PlayerData()
    {
        players = new List<Player>();
        players.Add(new Player(GameObject.Find("Bullhorncar").GetComponent<MovePiece>(), ""));
    }

    public Player Get(int num)
    {
        return players[num];
    }
}
