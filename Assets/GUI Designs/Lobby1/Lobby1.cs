using UnityEngine;
using System.Collections;

public class Lobby1 : MonoBehaviour {

	public Texture crashDrive;
	Rect titleRect = new Rect(50, 50, 800, 80);
	Rect backRect = new Rect(670, 130, 180, 25);
	Rect gameListRect = new Rect(50, 180, 530, 380);
	Rect gameIPRect = new Rect(600, 180, 280, 200);
	Rect gameHostRect = new Rect(600, 400, 280, 160);
	Rect woogleRect = new Rect(Screen.width-260, Screen.height-25, 180, 25);

	bool toggleValue = false;
	Vector2 scrollPos;

	void OnGUI(){
		
		// GUI selection
		if (GUIDesigns.guiSelect == 3) {

			GUI.Label(titleRect, crashDrive);
			if(GUI.Button(backRect, "Back to main menu")){
				
			}
			
			gameListRect = GUILayout.Window(1, gameListRect, gameListWindow, "Join a game via the list");
			gameIPRect = GUILayout.Window(2, gameIPRect, gameIPWindow, "Directly join a game via an IP");
			gameHostRect = GUILayout.Window(3, gameHostRect, gameHostWindow, "Host a game");

			if(GUI.Button(woogleRect, "WOOGLE.COM")){
				
			}
		}
	}
	
	void gameListWindow(int id){
		if(GUILayout.Button("Refresh available Servers", GUILayout.Width(180), GUILayout.Height(30))){
			
		}

		scrollPos = GUILayout.BeginScrollView (scrollPos, false, true);
			serverList (25);
		GUILayout.EndScrollView ();
	}

	void gameIPWindow(int id){
		GUILayout.BeginHorizontal ();
			GUILayout.TextField("127.0.0.1");
			GUILayout.TextField("25005");
		GUILayout.EndHorizontal ();
		GUILayout.Toggle (toggleValue, "Advanced. Use NAT");
		if(GUILayout.Button("Connect", GUILayout.Width(70), GUILayout.Height(30))){
			
		}
	}

	void gameHostWindow(int id){
			GUILayout.BeginHorizontal ();
				GUILayout.Label ("Use port:");
				GUILayout.TextField ("25005");
			GUILayout.EndHorizontal ();

			GUILayout.BeginHorizontal ();
			GUILayout.Label ("Players:");
			GUILayout.TextField ("8");
			GUILayout.EndHorizontal ();

			if(GUILayout.Button("Start hosting a server", GUILayout.Width(150), GUILayout.Height(30))){
				
			}
	}



	void serverList(int num){
		int i = num;
		for(; i>0; i--){
			GUILayout.BeginHorizontal ();
				GUILayout.Label ("Sean's game");
				GUILayout.Label ("7/8");
				GUILayout.Label ("195.49.160.178:25005");
				if(GUILayout.Button("Connect", GUILayout.Width(70), GUILayout.Height(25))){
					
				}
			GUILayout.EndHorizontal ();
		}
	}
}
