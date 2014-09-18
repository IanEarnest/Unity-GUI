using UnityEngine;
using System.Collections;

public class GUIDesigns : MonoBehaviour {

	public static int guiSelect = 0;
	Rect backRect = new Rect(Screen.width-80, Screen.height-100, 80, 30);

	void OnGUI(){
		// GUI selection
		if(guiSelect == 0){
			GUILayout.Label ("GUI Select");
			if(GUILayout.Button("Interface")){
				guiSelect = 1;
			}
			if(GUILayout.Button("Chatscript")){
				guiSelect = 2;
			}
			if(GUILayout.Button("Lobby 1")){
				guiSelect = 3;
			}
			if(GUILayout.Button("Lobby 2")){
				guiSelect = 4;
			}
		}

		// Back button
		if(guiSelect != 0){
			if(GUI.Button(backRect, "GUI Select")){
				guiSelect = 0;
			}
		}
	}
}
