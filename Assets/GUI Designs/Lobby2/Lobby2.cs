using UnityEngine;
using System.Collections;

public class Lobby2 : MonoBehaviour {

	Rect gameLobbyRect = new Rect(200, 0, 550, 200);
	Rect backRect = new Rect(100, 0, 180, 40);
	Rect chatWindow = new Rect(Screen.width/2-400, Screen.height-200, 800, 50);
	
	string chat = "";
	string message = "";


	void OnGUI(){

		// GUI selection
		if (GUIDesignsMenu.guiSelect == 4) {
			if(GUI.Button(backRect, "Back to menu")){

			}

			gameLobbyRect = GUILayout.Window(1, gameLobbyRect, gameLobbyWindow, "Game lobby");
			chatWindow = GUILayout.Window(2, chatWindow, chatFunction, "");
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


	Vector2 scrollPos;
	
	// Window 1
	void chatFunction(int id){
		scrollPos = GUILayout.BeginScrollView (scrollPos, GUILayout.Width(780), GUILayout.Height(135));
		GUILayout.Label (chat);
		GUILayout.EndScrollView ();
		GUILayout.Space (10);
		
		GUILayout.BeginHorizontal ();
		message = GUILayout.TextField(message);
		
		/*
			if(GUILayout.Button("Send", GUILayout.Width(100))){
				sendMessageToChat();
			}
			if (Input.GetKeyDown(KeyCode.Return)) {
				sendMessageToChat();
			}
		*/
		if (GUILayout.Button ("Send", GUILayout.Width (100)) || Event.current.type == EventType.KeyDown) {
			sendMessageToChat();
		}
		
		GUILayout.EndHorizontal ();
	}
	
	void sendMessageToChat(){
		// add new line to each message
		if(message != ""){
			chat += "\nYou said: "+message;
			message = "";
			scrollPos.y = 10000;
		}
	}
}
