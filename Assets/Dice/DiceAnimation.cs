using UnityEngine;
using System.Collections;

public class DiceAnimation : MonoBehaviour {
	
	public int diceNum1;
	public int diceNum2;
	public Transform diceTransform;
	
	// Use this for initialization
	void Start () {
		transform.animation.Play("roll");
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.animation["roll"].time>transform.animation["roll"].length)
		{
			KillDice();
		}
	}
	
	void KillDice()
	{
		Dice dice = (Dice)diceTransform.GetComponent(typeof(Dice));
		dice.MovePiece(diceNum1+diceNum2);
		Destroy(gameObject);
	}
}
