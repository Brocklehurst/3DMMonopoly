using UnityEngine;
using System.Collections;

public class YourTurnUI : MonoBehaviour {

	void Start () {
		// Bottom Bar
		var bgBottom = UI.firstToolkit.addSprite("main_bottombar-bg.png", 0, 0, 1 );
		bgBottom.positionFromBottom(0,0);
		UIButton manage = UIButton.create ("mainBottom_btnManageUp.png", "mainBottom_btnManageDown.png", 0, 0);
		manage.positionFromBottom(0.005f,0);
		UIButton roll = UIButton.create ("mainBottom_btnRollUp.png", "mainBottom_btnRollDown.png", 0, 0);
		roll.positionFromBottom(0.005f,-0.127f);
		roll.onTouchUpInside += (a) => GameObject.Find("DiceSpawn").GetComponent<Dice>().RollDice();
		UIButton end = UIButton.create ("mainBottom_btnEndUp.png", "mainBottom_btnEndDown.png", 0, 0);
		end.positionFromBottom(0.005f,0.127f);
		UIButton stats = UIButton.create ("mainBottom_btnStatsUp.png", "mainBottom_btnStatsDown.png", 0, 0);
		stats.positionFromBottom(0.005f,0.063f);
		UIButton trade = UIButton.create ("mainBottom_btnTradeUp.png", "mainBottom_btnTradeDown.png", 0, 0);
		trade.positionFromBottom(0.005f,-0.063f);
		trade.onTouchUpInside += (a) => Helper.GameData.playerData.Current.Move(1);
		
		// Exit Button
		UIButton exit = UIButton.create("btnExitUp.png", "btnExitDown.png", 0, 0);
		exit.positionFromBottomRight(0,0);
		
		// Top Bar
		var bgTop = UI.firstToolkit.addSprite("mainTop_bg.png", 0, 0, 1 );
		bgTop.positionFromTop(0,0);
		var bgTop_frame = UI.firstToolkit.addSprite("mainTop_frame.png", 0, 0, 1 );
		bgTop_frame.positionFromTop(0,0);
		UIButton rightArrow = UIButton.create("mainTop_btnRightUp.png", "mainTop_btnRightDown.png", 0, 0);
		rightArrow.positionFromTop(0.005f,-0.169f);
		UIButton leftArrow = UIButton.create("mainTop_btnLeftUp.png", "mainTop_btnLeftDown.png", 0, 0);
		leftArrow.positionFromTop(0.05f,-0.169f);
		var playerMarker = UI.firstToolkit.addSprite("mainTop_select.png", 0, 0, 1 );
		playerMarker.positionFromTop(0.006f,-0.114f);
		
		//Chat Window
		var bgChat_bar = UI.firstToolkit.addSprite("chat_bgBar.png", 0, 0, 1);
		bgChat_bar.positionFromBottomLeft(0,0);
		var bgChat_input = UI.firstToolkit.addSprite("chat_bgInput.png", 0, 0, 1);
		bgChat_input.positionFromBottomLeft(0.005f,0.004f);
		UIButton chatSend = UIButton.create ("chat_btnSendUp.png", "chat_btnSendDown.png", 0, 0);
		chatSend.positionFromBottomLeft(0.005f,0.223f);
		var bgChat_main = UI.firstToolkit.addSprite("chat_bgMain.png", 0, 0, 1);
		bgChat_main.positionFromBottomLeft(0.042f,0);		
		/*
		UIButton roll = UIButton.create("playUp.png", "playDown.png", 0, 0);
		roll.onTouchUpInside += (a) => GameObject.Find("DiceSpawn").GetComponent<Dice>().RollDice();

		UIButton moveOne = UIButton.create("playUp.png", "playDown.png", 0, 50);
		moveOne.onTouchUpInside += (a) => Helper.GameData.playerData.Current.Move(1);
		*/	
	}
}
