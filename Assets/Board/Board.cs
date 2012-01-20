using UnityEngine;
using System.Collections;
using System.Xml;
using System.IO;
using System;

public class Board : MonoBehaviour
{
	public TextAsset boardXML;
	public BoardSpace[] spaces;
	const int spaceAmount = 40;
	BoardConsts boardConsts;
	
	// Use this for initialization
	void Start () {
		boardConsts = GetComponent<BoardConsts>();
		spaces = new BoardSpace[spaceAmount];
		LoadSpaces();
	}
	
	/// <summary>
	/// loads board information from file
	/// </summary>
	void LoadSpaces()
	{
		string xml = boardXML.text;
		XmlDocument doc = new XmlDocument();
		doc.LoadXml(xml);
		
		//parse nodes
		int boardIndex = 0;
		foreach (XmlNode node in doc.SelectSingleNode("board").ChildNodes)
		{
			//init space and set special properties
			BoardSpace space = null;
			switch (node.Name)
			{
				case "GoSpace":
					space = new GoSpace();
					break;
				case "FreeSpace":
					space = new FreeSpace();
					break;
				case "JailSpace":
					space = new JailSpace();
					break;
				case "SurpriseSpace":
					space = new SurpriseSpace();
					break;
				case "CommunitySpace":
					space = new CommunitySpace();
					break;
				case "TaxSpace":
					space = new TaxSpace();
					break;
				case "PropertySpace":
					space = new PropertySpace();
					break;
				case "RailroadSpace":
					space = new RailroadSpace();
					break;
				case "UtilitySpace":
					space = new UtilitySpace();
					break;
			}
			
			//if still null, skip
			if (space == null)
			{
				continue;
			}
			
			//now set offset regardless of type
			string[] grid = node.Attributes["grid"].Value.Split(',');
			int gridX = Convert.ToInt32(grid[0]);
			int gridZ = Convert.ToInt32(grid[1]);
			space.offset.x = boardConsts.Positions[gridX];
			space.offset.y = boardConsts.Height;
			space.offset.z = boardConsts.Positions[gridZ];
			
			//finally assign to array
			spaces[boardIndex++] = space;
		}
	}
	
	public void OnDrawGizmosSelected()
	{
		foreach (BoardSpace s in spaces)
		{
			Gizmos.DrawSphere (s.offset, 0.5f);
		}
	}
}
