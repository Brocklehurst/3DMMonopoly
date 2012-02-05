using UnityEngine;
using System.Collections;

public class Dice : MonoBehaviour
{
	public int dice1 = 0;
	public int dice2 = 0;
	public int diceResult = 0;

	public int playTimes = 0;
	public int playAgainTimes = 0;

	public bool inJail=false;
	public int jailTimes=0;

	public Transform playerTransform;
	public Transform cameraTransform;
	public Transform dicePrefab;

	void Start () {
	}

	public void RollDice()
	{
		//set camera to follow piece
		SmoothFollow follow = (SmoothFollow)cameraTransform.GetComponent(typeof(SmoothFollow));
		follow.target = playerTransform;

		NewValues();

		// Check to see if player is in jail
        if(!inJail)
		{
            // If doubles
			if(dice1 == dice2){
				playAgainTimes+=1;      // Add to combo of doubles
				Debug.Log("Double combo: " + playAgainTimes);
			}
            // If 3 doubles in a row
			if(playAgainTimes == 3){
				Debug.Log("Sent to jail for 3 doubles");
				inJail=true;        // Send to jail
			}else if(dice1 != dice2){
				playAgainTimes=0;       // Reset combo
			}
		}
		else
		{
            // If doubles
			if(dice1==dice2){
                Debug.Log("Out of jail");
				inJail=false;       // Get out of jail
			} else if(dice1 != dice2){
                jailTimes++;        // Add to number of rolls in jail
            }
            // If rolled 3 times in jail
			if(jailTimes==3){
                Debug.Log("Out of jail");
				jailTimes=0;        // Reset jail roll count
				inJail=false;       // Get out of jail
			}
		}
		RollAnim(dice1,dice2);
	}

	private void NewValues()
	{
		dice1 = Random.Range(1, 7);
		dice2 = Random.Range(1, 7);
		diceResult=dice1+dice2;
	    playTimes++;
	}

	private void RollAnim(int value1, int value2)
	{
		Transform diceAnim = Instantiate(dicePrefab, transform.position, transform.rotation) as Transform;
		DiceAnimation diceScript = diceAnim.gameObject.GetComponent<DiceAnimation>();
		diceScript.diceNum1=value1;
		diceScript.diceNum2=value2;
		diceScript.diceTransform=transform;
		diceScript.PlayAnim();
	}
}
