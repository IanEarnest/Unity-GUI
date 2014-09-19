using UnityEngine;
using System.Collections;

public class GUIResizing : MonoBehaviour {
	
	bool showHelp;
	public static bool adjustSize;
	string instructions = "No instructions";
	Rect helpRect = new Rect(Screen.width - 80, 0, 80, 25);
	Rect adjustRect = new Rect(Screen.width - 80, 25, 80, 25);


	Rect menuRect = new Rect(0, 150, 550, 0);

	int scrollLimit = 2000; // Max scroll limit.
	int scrolled = 0; // Count for scroll
	
	public static float X = 1f;
	public static float Y = 1f;
	public static float Z = 1f;
	
	
	void Start(){
		Screen.orientation = ScreenOrientation.AutoRotation;
	}
	
	// Move Update() to different game.
	void Update(){
		if (adjustSize) {
			float scrollWheel = Input.GetAxis ("Mouse ScrollWheel");
			if (scrolled < scrollLimit) {
				// Mouse scroll forwards.
				if (scrollWheel > 0) {
					// Move camera forward.
					Camera.main.transform.Translate (Vector3.forward * 5);
					X += 0.3f;
					Y += 0.3f;
					//MainMenu.Z++;
					scrolled++;
				}
			}
			if (scrolled > ~scrollLimit) { // ~ means reverse.
				// Mouse scroll backwards.
				if (scrollWheel < 0) {
					// Move camera back.
					Camera.main.transform.Translate (Vector3.back * 5);
					X -= 0.3f;
					Y -= 0.3f;
					scrolled--;
				}
			}
			if (Input.GetButtonDown ("Fire1")) {
				X += 0.3f;
				Y += 0.3f;
			}
			// On phone hold with one finger and tap with a second finger.
			// Display "Please adjust here to fit screen" options as a splash screen when start game on phone.
			if (Input.GetButtonDown ("Fire2")) {
				X -= 0.3f;
				Y -= 0.3f;
			}
		}
	}
	
	void OnGUI(){
		GUI.depth = 0;
		
		if(showHelp){
			if(GUI.Button(helpRect, "Hide Help")){
				showHelp = !showHelp;
			}
			
			if(Application.loadedLevelName == "Lobby"){
				instructions = "Press \"Host a game\" to start your own game, " +
					"\npress \"Refresh Hosts\" to list any other people hosting a game." +
						"\nWhen connected to a server press level buttons to load a level.";
			}
			GUI.Box(new Rect(0, 0, Screen.width, Screen.height), instructions);
		}
		else{
			if(GUI.Button(helpRect, "Show Help")){
				showHelp = !showHelp;
			}
			if(GUI.Button(adjustRect, "Adjust Size")){
				adjustSize = !adjustSize;
			}
		}


		menuRect = GUILayout.Window(1, menuRect, menuFunction, "Main Menu");
	}

	// Main Menu window
	void menuFunction(int id){
		if(GUILayout.Button("Play")){
			print ("Play");
		}
		if(GUILayout.Button("Options")){
			print ("Options");
		}
	}
}
