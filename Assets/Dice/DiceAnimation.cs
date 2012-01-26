using UnityEngine;
using System.Collections;

public class DiceAnimation : MonoBehaviour {
	
	public int diceNum1;
	public int diceNum2;
	public Transform diceTransform;
	Vector3 diceRot1;
	Vector3 diceRot2;

	// Use this for initialization
	void Start () {
	}

    public void PlayAnim()
    {
        GameObject.Find("Main Camera").GetComponent<SmoothFollow>().target = transform;
        //store proper rotates
        diceRot1 = RotateDiceToAdd(diceNum1);
        diceRot2 = RotateDiceToAdd(diceNum2);
        transform.animation.Play("roll");
    }

	// Update is called once per frame
	void Update () {
		if(!animation.IsPlaying("roll"))
		{
			KillDice();
		}
	}

	// LateUpdate is called once per frame AFTER Update and animation overrides!
	void LateUpdate()
	{
		transform.FindChild("Cube_004").transform.Rotate(diceRot1);
		transform.FindChild("Cube_002").transform.Rotate(diceRot2);
	}

	/// <summary>
	/// selects the proper rotation to add on every frame
	/// </summary>
	/// <param name="number">
	/// A <see cref="System.Int32"/> representing dice roll
	/// </param>
	/// <returns>
	/// A <see cref="Quaternion"/> holding the rotation to add
	/// </returns>
	Vector3 RotateDiceToAdd(int number)
	{
		Vector3 rot = Quaternion.Euler(Vector3.zero).eulerAngles;
		switch (number)
		{
		case 1:
			rot = Quaternion.Euler(0,0,180).eulerAngles;
			break;
		case 2:
			rot = Quaternion.Euler(-90,0,0).eulerAngles;
			break;
		case 3:
			rot = Quaternion.Euler(0,0,90).eulerAngles;
			break;
		case 4:
			rot = Quaternion.Euler(0,0,-90).eulerAngles;
			break;
		case 5:
			rot = Quaternion.Euler(90,0,0).eulerAngles;
			break;
		case 6:
			rot = Quaternion.Euler(0,0,0).eulerAngles;
			break;
		}

		return rot;
	}

	void KillDice()
	{
		GameObject.Find("Main Camera").GetComponent<SmoothFollow>().target = GameObject.Find("Bullhorncar").transform;
		Dice dice = (Dice)diceTransform.GetComponent(typeof(Dice));
		dice.MovePiece(diceNum1+diceNum2);
		Destroy(gameObject);
	}
}
