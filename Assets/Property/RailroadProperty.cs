using UnityEngine;
using System.Collections;

//represents a "railroad" property
public class RailroadProperty : Property
{
	readonly int[] fines = { 25, 50, 100, 200 };

	public RailroadProperty(int p, int mort)
		: base(p, mort)
	{
	}

	public override int CalculateFine (Player p)
	{
		return fines[p.Railroads];
	}
}
