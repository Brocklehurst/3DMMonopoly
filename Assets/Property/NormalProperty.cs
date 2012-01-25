using UnityEngine;
using System.Collections;

//represents a "normal" property, one with houses/hotel
public class NormalProperty : Property
{
	public enum HouseAmount { None, House1, House2, House3, House4, Hotel }
	HouseAmount houses;
	int housePrice;
	int[] fines;

	public NormalProperty(int p, int mort, int hp, int[] fs)
		: base(p, mort)
	{
		houses = HouseAmount.None;
		housePrice = hp;
		fines = fs;
	}

	public override int CalculateFine (Player p)
	{
		return fines[(int)houses];
	}
}
