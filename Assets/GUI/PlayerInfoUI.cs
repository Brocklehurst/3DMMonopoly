using UnityEngine;
using System.Collections;

public class PlayerInfoUI : MonoBehaviour {
    void OnGUI() {
		GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "This is a title");
        if (GUI.Button(new Rect(10, 10, 150, 100), "I am a button")){
            print("You clicked the button!");
		}
        
    }
}
