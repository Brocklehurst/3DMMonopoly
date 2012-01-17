using UnityEngine;
using System.Collections;

public class MovePiece : MonoBehaviour {

	public Vector3[] boardPath;
	public int currentPoint = 0;
	
	void Start()
	{
	}

	public void OnDrawGizmos()
	{
		iTween.DrawPathGizmos(boardPath);
		for(int i=0;i<boardPath.Length;i++){
			Gizmos.DrawSphere (boardPath[i], 0.5f);
		}
	}

	public void Move(int amountMove)
	{
		iTween.MoveTo(gameObject,boardPath[currentPoint+amountMove],3);
		currentPoint+=amountMove;
	}
}
