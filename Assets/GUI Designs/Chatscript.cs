using UnityEngine;
using System.Collections;

public class Chatscript : MonoBehaviour {

	Rect window1Rect = new Rect(Screen.width/2-75, Screen.height-200, 150, 50);

	string chat = "hi";
	string message = "";

	void OnGUI(){
		window1Rect.y = Screen.height - window1Rect.height;
		if (GUIDesigns.guiSelect == 2) {
			window1Rect = GUILayout.Window(1, window1Rect, window1Function, "Chat");
		}
	}

	
	// Window 1
	void window1Function(int id){
		GUILayout.Label (chat);
		GUILayout.Space (90);

		message = GUILayout.TextArea(message);
		if(GUILayout.Button("Send")){
			chat += "\n"+message;
			message = "";
		}
	}
}
