using UnityEngine;
using System.Collections;

public class Welcome : MonoBehaviour {

	Rect welcomeRect = new Rect(0, 0, Screen.width, Screen.height);
	Rect[] rectArray = new Rect[9];
	Images ScriptImages;

	void Start(){
		// First level "Main menu" does not have Script1 as it does not go
		// back anywhere, so attach images script to main camera instead
		if(Application.loadedLevel != 0)
			ScriptImages = GameObject.Find("Script1").AddComponent <Images> ();
		else
			ScriptImages = Camera.main.gameObject.AddComponent <Images> ();
	}

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

			if(i == 0 || i == 3 || i == 6){
				GUILayout.BeginHorizontal();

			}

				// Set scene name
				//string sceneText = "Scene " + (i+1) + " - ";

				if(GUILayout.Button(new GUIContent(/*sceneText + */levelName[i], ScriptImages.images[i]), 
			                    				   GUILayout.Width(300), GUILayout.Height(100))){
					Application.LoadLevel(levelName[i]);	
				}
				// Get rect for each GUILayout
				rectArray[i] = GUILayoutUtility.GetLastRect();
				
				i++;

			if(i == 3 || i == 6 || i == 9){
				GUILayout.EndHorizontal();
				GUILayout.Space(50);
			}
		}

		GUILayout.Label ("GUI Resizing and GUI Window are in progress");

		// Hover over buttons
		i = 0;
		for(; i<rectArray.Length; i++){
			if(rectArray[i].Contains(Event.current.mousePosition)){
				GUI.Label(new Rect(150,100,600,600)/*rectArray[i]*/, ScriptImages.images[i]);
				GUI.Box(new Rect(150,100, 600, 30), levelName[i]);
				
			}
		}
	}
}
