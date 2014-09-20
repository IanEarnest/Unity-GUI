using UnityEngine;
using System.Collections;

public class Chatscript : MonoBehaviour {

	Rect chatWindow = new Rect(Screen.width/2-400, Screen.height-200, 800, 50);

	string chat = "";
	string message = "";

	void OnGUI(){


		//window1Rect.y = Screen.height - window1Rect.height;
		if (GUIDesigns.guiSelect == 2) {
			chatWindow = GUILayout.Window(1, chatWindow, chatFunction, "");
		}
	}

	Vector2 scrollPos;

	// Window 1
	void chatFunction(int id){
		scrollPos = GUILayout.BeginScrollView (scrollPos, false, true, GUILayout.Width(780), GUILayout.Height(135));
			GUILayout.Box (chat);
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
