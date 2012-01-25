using UnityEngine;
using System.Collections;

//represents a "utility" property
public class UtilityProperty : Property
{
	public UtilityProperty(int p, int mort)
		: base(p, mort)
	{
	}

	//does 4 or 10 times dice roll
	public override int CalculateFine (Player p)
	{
		int fine = 0;
		switch (p.Utilities)
		{
		case 1:
			fine = p.LastDiceRoll * 4;
			break;
		case 2:
			fine = p.LastDiceRoll * 10;
			break;
		}

		return fine;
	}
}
