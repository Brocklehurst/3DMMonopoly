using UnityEngine;
using System.Collections;

//contains all data about the current game
public class Data : MonoBehaviour
{
	public BoardData boardData;
	public PropertyData properties;
	public PlayerData playerData;
	public BoardConsts boardConsts;
	public UIData uiData;
	public TextAsset boardXML;

	void Start ()
	{
		properties = new PropertyData();
		boardData = new BoardData();
		playerData = new PlayerData();
		uiData = new UIData();
	}
}
