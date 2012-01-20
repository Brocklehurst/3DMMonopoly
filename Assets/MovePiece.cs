using UnityEngine;
using System.Collections;

public class MovePiece : MonoBehaviour {

	public int boardIndex = 0;
	public Board parent;

	void Start()
	{
	}

	public void Move(int amountMove)
	{
		int moveVector = (boardIndex + amountMove) % parent.spaces.Length;
		iTween.MoveTo(gameObject,parent.spaces[moveVector].offset,3);
		boardIndex=moveVector;
	}
}
