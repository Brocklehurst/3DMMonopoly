using UnityEngine;
using System.Collections;

//contains all data about the current game
public class Data : MonoBehaviour
{
	public BoardData boardData;
	public PropertyInfo properties;
	public Player player;
	public BoardConsts boardConsts;
	public TextAsset boardXML;

	void Start ()
	{
		properties = new PropertyInfo();
		boardData = new BoardData();
		player = new Player();
	}
}
