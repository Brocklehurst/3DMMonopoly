using UnityEngine;
using System.Collections;

public class MovePiece : MonoBehaviour
{
	Player parent;

	void Start()
	{
	}

	public Player Parent
	{
		set { parent = value; }
	}

	public void MoveTo(Hashtable args)
	{
		iTween.MoveTo(gameObject, args);
	}

<<<<<<< HEAD
	//we need method calls for iTween, just call parent calls
    public void Move(int i)
    {
        parent.Move(i);
=======
	//we need method calls for iTween, just call parent calls
    public void Move(int i)
    {
        parent.Move(i);
>>>>>>> upstream/master
    }

	public void Land()
	{
		parent.Land();
	}
}
