using UnityEngine;
using System.Collections;

public class RollButtonClick : MonoBehaviour {

	void OnClick()
	{
		GameObject.Find("DiceSpawn").GetComponent<Dice>().RollDice();
		Helper.GameData.uiData.DisablePiece(gameObject);
	}
}
