using UnityEngine;
using System.Collections;

public class GUIDesigns : MonoBehaviour {

	int guiSelect = 0;
	Rect backRect = new Rect(Screen.width-100, Screen.height/2, 100, 50);

	Rect window1Rect = new Rect(Screen.width/2-75, Screen.height/2-100, 150, 50);

	void OnGUI(){
		if(guiSelect != 0){
			if(GUI.Button(backRect, "GUI Select")){
				guiSelect = 0;
			}
		}

		if(guiSelect == 0){
			GUILayout.Label ("GUI Select");
			if(GUILayout.Button("GUI 1")){
				guiSelect = 1;
			}
			if(GUILayout.Button("GUI 2")){
				guiSelect = 2;
			}
			if(GUILayout.Button("GUI 3")){
				guiSelect = 3;
			}
		}


		if (guiSelect == 1) {
			window1Rect = GUILayout.Window(1, window1Rect, window1Function, "Main Menu");

			GUILayout.BeginHorizontal();
				GUILayout.Label("Healthy");
				GUILayout.Space (50);
				GUILayout.Label("Nourished");
				GUILayout.Space (50);
				GUILayout.Label("Normal");
			GUILayout.EndHorizontal();
		}

	}

	
	// Window 1
	void window1Function(int id){
		if(GUILayout.Button("Continue")){

		}
		GUILayout.Space (20);
		if(GUILayout.Button("Settings")){
			
		}
		GUILayout.Space (5);
		if(GUILayout.Button("Instructions")){
			
		}
		GUILayout.Space (20);
		if(GUILayout.Button("Inventory")){
			
		}
		GUILayout.Space (5);
		if(GUILayout.Button("Map")){
			
		}
		GUILayout.Space (5);
		if(GUILayout.Button("Logout")){
			
		}
	}
}
