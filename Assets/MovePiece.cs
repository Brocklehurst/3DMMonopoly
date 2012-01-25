using UnityEngine;
using System.Collections;

public class MovePiece : MonoBehaviour
{
	public int boardIndex = 0;
	public BoardData parent;

	void Start()
	{
		parent = Helper.GameData.boardData;
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

		iTween.MoveTo(gameObject, args);
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
	}
}
