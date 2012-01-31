using UnityEngine;
using System.Collections;

public class DiceAnimation : MonoBehaviour {
	
	public int diceNum1;
	public int diceNum2;
	public Transform diceTransform;

	// Use this for initialization
	void Start () {
	}

    public void PlayAnim()
    {
        GameObject.Find("Main Camera").GetComponent<SmoothFollow>().target = transform;
        transform.FindChild("Cube_004").FindChild("dice_model").Rotate(RotateDice(diceNum1));
        transform.FindChild("Cube_002").FindChild("dice_model").Rotate(RotateDice(diceNum2));
        transform.animation.Play("roll");
    }

	// Update is called once per frame
	void Update () {
		if(!animation.IsPlaying("roll"))
		{
			KillDice();
		}
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
	Vector3 RotateDice(int number)
	{
		Vector3 rot = Quaternion.Euler(Vector3.zero).eulerAngles;
		switch (number)
		{
		case 1:
			rot = Quaternion.Euler(0,0,180).eulerAngles;
			break;
		case 2:
			rot = Quaternion.Euler(0,0,-90).eulerAngles;
			break;
		case 3:
			rot = Quaternion.Euler(0,90,0).eulerAngles;
			break;
		case 4:
			rot = Quaternion.Euler(0,-90,0).eulerAngles;
			break;
		case 5:
			rot = Quaternion.Euler(0,0,90).eulerAngles;
			break;
		case 6:
			rot = Quaternion.Euler(0,0,0).eulerAngles;
			break;
		}

		return rot;
	}

	void KillDice()
	{
		GameObject.Find("Main Camera").GetComponent<SmoothFollow>().target = Helper.GameData.playerData.Current.Piece;
		Destroy(gameObject);
		Helper.GameData.playerData.Current.Move(diceNum1 + diceNum2);
	}
}
