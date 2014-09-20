using UnityEngine;
using System.Collections;

public class Lobby2 : MonoBehaviour {

	Rect gameLobbyRect = new Rect(200, 0, 550, 200);
	Rect backRect = new Rect(100, 0, 180, 40);

	void OnGUI(){

		// GUI selection
		if (GUIDesigns.guiSelect == 4) {
			if(GUI.Button(backRect, "Back to menu")){

			}

			gameLobbyRect = GUILayout.Window(1, gameLobbyRect, gameLobbyWindow, "Game lobby");
		}
	}

	void gameLobbyWindow(int id){
		GUILayout.Label ("Password protected" + "\t\t" + "yes");
		GUILayout.Label ("Server title" + "\t\t\t\t\t\t" + "Come & Play!");
		GUILayout.Label ("Players" + "\t\t\t\t\t\t\t" + "1/16");
		GUILayout.Label ("Current players" + "\t\t\t\t" + "Leepo");

		GUILayout.Space (50);

		if(GUILayout.Button("Start the game", GUILayout.Width(180), GUILayout.Height(40))){
			
		}
	}
}
