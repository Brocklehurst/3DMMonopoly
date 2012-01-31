using UnityEngine;
using System.Collections.Generic;
using System.Collections;

//represents a single player in the game
public class Player
{
    int money;
    int railroads;
    int utilities;
    int lastDiceRoll;
    string name;
    int boardIndex;
    bool inJail;
    BoardData parent;
    MovePiece piece;

    public Player(MovePiece p, string n)
    {
        railroads = 0;
        utilities = 0;
        lastDiceRoll = 0;
        boardIndex = 0;
        inJail = false;
        name = n;
        parent = Helper.GameData.boardData;
        piece = p;
        piece.Parent = this;
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
    public int BoardIndex
    {
        get { return boardIndex; }
        set { boardIndex = value; }
    }
	public Transform Piece
	{
		get { return piece.transform; }
	}
    #endregion

    /// <summary>
    /// looks up the properties this player owns from the table
    /// </summary>
    /// <returns>
    /// A <see cref="Property[]"/> array containing all properties this player owns
    /// </returns>
    public Property[] OwnedProperties()
    {
        List<Property> props = new List<Property>();
        foreach (Pair<Property, Player> p in Helper.GameData.properties.OwnershipTable)
        {
            if (p.Second == this)
            {
                props.Add(p.First);
            }
        }

        return props.ToArray();
    }

    public void Move(int amountMove)
    {
        --amountMove;
        //increment but wrap
        boardIndex = (boardIndex + 1) % parent.Spaces.Length;
        Hashtable args = new Hashtable() {
			{"position", parent.Spaces[boardIndex].offset},
			{"time", 0.3f} };
        if (amountMove > 0)
        {
            Pass();
            //continue moving
            args.Add("oncomplete", "Move");
            args.Add("oncompleteparams", amountMove);
        }
        else
        {
            //last one, finally land
            args.Add("oncomplete", "Land");
        }

        piece.MoveTo(args);
    }

    /// <summary>
    /// what happens when passing by a space
    /// </summary>
    public void Pass()
    {
    }

    /// <summary>
    /// what happens when landing on a space
    /// </summary>
    public void Land()
    {
        parent.Spaces[boardIndex].Land();
		Helper.GameData.playerData.NextTurn();
		Helper.GameData.playerData.CameraToCurrent();
    }
}
