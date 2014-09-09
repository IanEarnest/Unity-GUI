﻿using UnityEngine;
using System; // system is only used on standalone.
using System.Collections;

public class Welcome : MonoBehaviour {

	public GUISkin normalGUISkin;
	Rect menuRect = new Rect(0, 0, Screen.width, Screen.height);
		
	void OnGUI(){
		// Reset GUI skin and fontSizes
		GUI.skin = normalGUISkin;
		GUI.skin.button.fontSize = 0;
		GUI.skin.box.fontSize = 0;
		GUI.skin.label.fontSize = 0;

		menuRect = GUILayout.Window(0, menuRect, menuFunction, "Main Menu");
	}

	// Main Menu window
	void menuFunction(int id){
		GUILayout.Label ("Welcome, please select a scene");
		if(GUILayout.Button("Scene 1 - Cameras")){
			Application.LoadLevel("Cameras");
		}
		if(GUILayout.Button("Scene 2 - GUI Designs")){
			//Application.LoadLevel("Cameras");
		}
		if(GUILayout.Button("Scene 3 - GUI Resizing")){
			Application.LoadLevel("GUIResizing");
		}
		if(GUILayout.Button("Scene 4 - GUI Window")){
			Application.LoadLevel("GUIWindow");
		}
		if(GUILayout.Button("Scene 5 - OnGUI")){
			Application.LoadLevel("GUI");
		}
		if(GUILayout.Button("Scene 6 - Loading Levels")){
			Application.LoadLevel("Loading Levels");
		}
		if(GUILayout.Button("Scene 7 - System Info")){
			Application.LoadLevel("SystemInfo");
		}
		if(GUILayout.Button("Scene 8 - Text 3D")){
			Application.LoadLevel("Text3D");
		}

	}
}
