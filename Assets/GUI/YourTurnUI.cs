using UnityEngine;
using System.Collections;

public class YourTurnUI : MonoBehaviour {

	void Start () {
		UIButton roll = UIButton.create("playUp.png", "playDown.png", 0, 0);
		roll.onTouchUpInside += (a) => GameObject.Find("DiceSpawn").GetComponent<Dice>().RollDice();

		UIButton moveOne = UIButton.create("playUp.png", "playDown.png", 0, 50);
		moveOne.onTouchUpInside += (a) => Helper.GameData.playerData.Current.Move(1);
	}
}
