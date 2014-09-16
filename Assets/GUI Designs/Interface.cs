using UnityEngine;
using System.Collections;

public class Interface : MonoBehaviour {

	Rect window1Rect = new Rect(Screen.width/2-75, Screen.height/2-100, 150, 50);

	void OnGUI(){
		if (GUIDesigns.guiSelect == 1) {
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
