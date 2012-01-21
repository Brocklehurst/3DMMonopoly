using UnityEngine;
using System.Collections;

public class TakeCard : MonoBehaviour {
	
	public bool isPlaying = false;
	public Transform initCard = null;
	public Transform spawnPoint = null;
	private Transform ChanceCard = null;
	
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
				Vector3 cameraTransform = Camera.main.transform.position;
				Vector3 cameraForward = Camera.main.transform.forward;
				ChanceCard = (Transform) Instantiate(initCard, spawnPoint.position, spawnPoint.rotation); //Create card at spawn
				Hashtable hashToCam = new Hashtable() {
				{"position", cameraTransform+cameraForward*1.5f},
				{"looktarget", cameraTransform},
				{"time", 2.0f} };
				iTween.Stop();
				iTween.MoveTo(ChanceCard.gameObject, hashToCam); 
			}
		}
		if (GUI.Button (new Rect(20,80,120,20), "Put Card Back"))
		{
			// if animation isn't playing already
			if(isPlaying)
			{
				if(ChanceCard!=null){
					Debug.Log(spawnPoint.rotation);
					Hashtable hashToPile = new Hashtable() {
					{"position", spawnPoint.position+spawnPoint.forward*0.5f},
					{"time", 2.0f}};
					Hashtable hashToPile_rot = new Hashtable() {
					{"rotation", spawnPoint},
					{"oncomplete", "EndOfCard"},
					{"oncompletetarget", gameObject},
					{"time", 2.0f}};
					iTween.Stop();
					iTween.MoveTo(ChanceCard.gameObject, hashToPile);
					iTween.RotateTo(ChanceCard.gameObject, hashToPile_rot); 
				}			
			}
		}
	}
	
	public void EndOfCard(){
		Destroy(ChanceCard.gameObject);
		isPlaying=false;
	}
}
