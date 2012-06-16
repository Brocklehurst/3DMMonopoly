using UnityEngine;
using System.Collections;

public class PlayerInfoUI : MonoBehaviour {
	
	public string playerName;
	
	void Start(){
		if(PlayerPrefs.GetString("Player Name")!=null){
			playerName=PlayerPrefs.GetString("Player Name");
		} else {
			playerName="Enter name";
		}
	}
	
    void OnGUI() {
		GUI.Box(new Rect((Screen.width-500)/2, (Screen.height-200)/2, 500, 200), "\n Please enter you name and press Start.");
        playerName = GUI.TextField(new Rect((Screen.width-200)/2, (Screen.height-20)/2, 200, 20), playerName, 25);
		if (GUI.Button(new Rect((Screen.width-100)/2, (Screen.height+50)/2, 100, 50), "Start")){
            PlayerPrefs.SetString ("Player Name",playerName);
			Application.LoadLevel("MainGameplay");
		}
        
    }
}
