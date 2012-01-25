using UnityEngine;
using System.Collections;

//contains all data about the current game
public class Data : MonoBehaviour
{
	public BoardData boardData;
	public PropertyData properties;
	public Player player;
	public BoardConsts boardConsts;
	public TextAsset boardXML;

	void Start ()
	{
		properties = new PropertyData();
		boardData = new BoardData();
		player = new Player();
	}
}
