using UnityEngine;
using System.Collections;
using System.Xml;
using System.IO;
using System;

//contains all data about the board
public class BoardData
{
	TextAsset boardXML;
	BoardConsts boardConsts;
	PropertyData props;
	BoardSpace[] spaces;
	const int spaceAmount = 40;

	public BoardData()
	{
		Data d = Helper.GameData;
		boardXML = d.boardXML;
		boardConsts = d.boardConsts;
		props = d.properties;
		LoadSpaces();
	}

	public BoardSpace[] Spaces
	{
		get { return spaces; }
	}

	/// <summary>
	/// loads board information from file
	/// </summary>
	void LoadSpaces()
	{
		spaces = new BoardSpace[spaceAmount];
		string xml = boardXML.text;
		XmlDocument doc = new XmlDocument();
		doc.LoadXml(xml);

		//parse nodes
		int boardIndex = 0;
		int propIndex = 0;
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
					//parse property info
					string name = node.Attributes["name"].Value;
					int price = Convert.ToInt32(node.Attributes["price"].Value);
					int house = Convert.ToInt32(node.Attributes["house"].Value);
					int mort = Convert.ToInt32(node.Attributes["mortgage"].Value);
					XmlNodeList fineNodes = node.SelectNodes("fines/fine/text()");
					int[] fines = new int[fineNodes.Count];
					int i = 0;
					foreach (XmlNode fine in fineNodes)
					{
						fines[i++] = Convert.ToInt32(fine.Value);
					}

					NormalProperty p = new NormalProperty(price, mort, house, fines);
					((PropertySpace)space).SetProperty(propIndex++, p);
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
}
