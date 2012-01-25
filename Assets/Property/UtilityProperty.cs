using UnityEngine;
using System.Collections;

//represents a "utility" property
public class UtilityProperty : Property
{
	public UtilityProperty(int p, int mort)
		: base(p, mort)
	{
	}

	public override int CalculateFine (Player p)
	{
		return 0;
	}
}
