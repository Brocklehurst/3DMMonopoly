using UnityEngine;
using System.Collections;

public class TakeCard : MonoBehaviour {
	
	public bool isPlaying = false;
	public Transform initCard = null;
	public Transform spawnPoint = null;

	/// <summary>
	/// GUI calls
	/// </summary>
	void OnGUI()
	{
		if (GUI.Button (new Rect(20,40,80,20), "Take Card"))
		{
			// if animation isn't playing already
			if(!isPlaying)
			{
				isPlaying=true;
				Transform cameraTransform = Camera.main.transform;
				GameObject ChanceCard = (GameObject) Instantiate(initCard, spawnPoint.position, spawnPoint.rotation); //Create card at spawn
				iTween.MoveTo(ChanceCard, new Hashtable() { {"position", cameraTransform}, {"time", 3.0f} }); 
			}
		}
	}
}
