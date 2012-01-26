using UnityEngine;
using System.Collections;

public class DiceAnimation : MonoBehaviour {
	
	public Transform dice1Transform;
	public Transform dice2Transform;
	public int diceNum1;
	public int diceNum2;
	public Transform diceTransform;
	
	// Use this for initialization
	void Start () {
		RotateDice(dice1Transform,diceNum1);
		RotateDice(dice2Transform,diceNum2);
		transform.animation.Play("roll");
	}
	
	// Update is called once per frame
	void Update () {
		if(!animation.IsPlaying("roll"))
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
	
	void RotateDice(Transform dice, int number)
	{
		
			if(number==1){
				dice.rotation = Quaternion.Euler(0,0,90);
			} else if(number==2){
				dice.rotation = Quaternion.Euler(0,0,90);
			} else if(number==3){
				dice.rotation = Quaternion.Euler(0,90,0);
			} else if(number==4){
				dice.rotation = Quaternion.Euler(0,-90,0);
			} else if(number==5){
				dice.rotation = Quaternion.Euler(0,0,90);
			} else if(number==6){
				dice.rotation = Quaternion.Euler(0,0,0);
			}
	}
}
