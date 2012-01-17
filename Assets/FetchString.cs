using UnityEngine;
using System.Collections;

public class FetchString : MonoBehaviour {
	
	public int diceResult = 0;
	public string urlData = "http://liambrocklehurst.com/uploader/files/1/texttest.txt";
	public string dataString;
	
	// Use this for initialization
	IEnumerator Start () {
	    WWW wwwData = new WWW(urlData);
		yield return wwwData;
	    dataString = wwwData.text;
	}
	
	void OnGUI () {
	    GUIStyle boxStyle = "box";
	    boxStyle.wordWrap = true;
		GUI.Box (new Rect (500,10,100,90), "Data Fetching");

		GUI.Box (new Rect (500,100,100,80), ""+dataString);	

	    // BUTTON - Fetch Data
		if (GUI.Button (new Rect (505,40,80,20), "Fetch Data")) {
        
		}
	}
}
