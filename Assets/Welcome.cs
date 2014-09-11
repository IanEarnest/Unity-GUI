using UnityEngine;
using System.Collections;

public class Welcome : MonoBehaviour {

	Rect welcomeRect = new Rect(0, 0, Screen.width, Screen.height);
		
	void OnGUI(){
		welcomeRect = GUILayout.Window(0, welcomeRect, welcomeFunction, "Welcome Menu");
	}

	// Main Menu window
	void welcomeFunction(int id){
		GUILayout.Label ("Welcome, please select a scene");

		// List of levels
		string[] levelName = {"Cameras", "GUI Designs", "GUI Moveable", 
		"GUI Resizing", "GUI Window", "OnGUI", 
		"Loading Levels", "System Info", "Text 3D"};

		int i = 0; // Level increment
		// Each level in the array as a button with sceneText, level number and name.
		foreach(string text in levelName){
			// Set scene name
			string sceneText = "Scene " + (i+1) + " - ";

			if(GUILayout.Button(sceneText + levelName[i])){
				Application.LoadLevel(levelName[i]);
			}
			i++;
		}
	}
}
