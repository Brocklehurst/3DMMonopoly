using UnityEngine;

using System.Collections;
using System.Xml;
using System.IO;
using System;

public class Board : MonoBehaviour
{
	public TextAsset boardXML;
	public BoardSpace[] spaces;
	public BoardConsts boardConsts;
	
	// Use this for initialization
	void Start () {
		boardConsts = GetComponent<BoardConsts>();
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
					space = gameObject.AddComponent<GoSpace>();
					break;
				case "FreeSpace":
					space = gameObject.AddComponent<FreeSpace>();
					break;
				case "JailSpace":
					space = gameObject.AddComponent<JailSpace>();
					break;
				case "SurpriseSpace":
					space = gameObject.AddComponent<SurpriseSpace>();
					break;
				case "CommunitySpace":
					space = gameObject.AddComponent<CommunitySpace>();
					break;
				case "TaxSpace":
					space = gameObject.AddComponent<TaxSpace>();
					break;
				case "PropertySpace":
					space = gameObject.AddComponent<PropertySpace>();
					break;
				case "RailroadSpace":
					space = gameObject.AddComponent<RailroadSpace>();
					break;
				case "UtilitySpace":
					space = gameObject.AddComponent<UtilitySpace>();
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
	
	public void OnDrawGizmos()
	{
//		foreach (BoardSpace s in spaces)
//		{
//			Gizmos.DrawSphere (s.offset, 0.5f);
//		}
	}
	
}
