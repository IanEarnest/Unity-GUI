using UnityEngine;
using System; // system is only used on standalone.
using System.Collections;

public class Welcome : MonoBehaviour {
	
	//Rect menuRect = new Rect(0, 0, 150, 0);
	Rect menuRect = new Rect(0, 150, 550, 0); // Keeps window big for now.
	Rect optionsRect = new Rect(150, 0, 150, 0);
	
	bool openOptions;
	
	void OnGUI(){
		if (GUIResizing.adjustSize) {
			// Move to different game.
			GUI.matrix = Matrix4x4.TRS (Vector3.zero, Quaternion.identity, new Vector3 (GUIResizing.X, GUIResizing.Y, GUIResizing.Z));
		}
		
		menuRect = GUILayout.Window(0, menuRect, menuFunction, "Main Menu");
		if(openOptions){
			optionsRect = GUILayout.Window(1, optionsRect, optionsFunction, "Options");
		}
	}
	
	
	
	// Main Menu window
	void menuFunction(int id){
		if(GUILayout.Button("Options")){
			openOptions = !openOptions;
		}
		if(GUILayout.Button("Link (opens in current window)")){
			Application.OpenURL("http://unity3d.com/");
		}
	}
	
	// Options window
	void optionsFunction(int id){
		
		GUILayout.Label("Nothing yet.");
		if(GUILayout.Button("Close")){
			openOptions = false;
		}
	}
}
