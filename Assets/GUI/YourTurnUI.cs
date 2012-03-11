using UnityEngine;
using System.Collections;

public class YourTurnUI : MonoBehaviour {

	void Start () {
		var mainBottomBG = UIButton.create("main_bottombar-bg.png", "main_bottombar-bg.png", 0, 0);
		mainBottomBG.positionFromBottom(0.003f,0);
		var manageButton = UIButton.create ("mainBottom_btnManageUp.png", "mainBottom_btnManageDown.png", 0, 0);
		manageButton.positionFromBottom(0.01f,0);
		var rollButton = UIButton.create ("mainBottom_btnRollUp.png", "mainBottom_btnRollDown.png", 0, 0);
		rollButton.positionFromBottom(0.01f,-0.146f);
		var endButton = UIButton.create ("mainBottom_btnEndUp.png", "mainBottom_btnEndDown.png", 0, 0);
		endButton.positionFromBottom(0.01f,0.146f);
		var statsButton = UIButton.create ("mainBottom_btnStatsUp.png", "mainBottom_btnStatsDown.png", 0, 0);
		statsButton.positionFromBottom(0.01f,0.073f);
		var tradeButton = UIButton.create ("mainBottom_btnTradeUp.png", "mainBottom_btnTradeDown.png", 0, 0);
		tradeButton.positionFromBottom(0.01f,-0.073f);
		/*
		UIButton roll = UIButton.create("playUp.png", "playDown.png", 0, 0);
		roll.onTouchUpInside += (a) => GameObject.Find("DiceSpawn").GetComponent<Dice>().RollDice();

		UIButton moveOne = UIButton.create("playUp.png", "playDown.png", 0, 50);
		moveOne.onTouchUpInside += (a) => Helper.GameData.playerData.Current.Move(1);
		*/	
	}
}
