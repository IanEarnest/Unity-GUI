using UnityEngine;
using System.Collections;

public class Interface : MonoBehaviour {

	Rect mainMenuRect = new Rect(Screen.width/2-75, Screen.height/2-100, 150, 50);

	Rect healthRect = new Rect(0, 0, 40, 50);
	Rect minimapRect = new Rect(Screen.width-150, 0, 150, 150);
	Rect weaponsRect = new Rect(0, Screen.height-115, 150, 200);
	Rect weaponImageRect = new Rect(0, Screen.height-60, 150, 65);
	Rect afkRect = new Rect(Screen.width/2-200, Screen.height-20, 400, 20);
	public Texture health, food, armour, map, weapon;

	void OnGUI(){
		if (GUIDesigns.guiSelect == 1) {
			mainMenuRect = GUILayout.Window(1, mainMenuRect, mainMenuWindow, "MAIN MENU");

			GUILayout.BeginHorizontal();
				GUILayout.Label(health);
				//imageBox(health);
				GUILayout.Label("HEALTHY");
				GUILayout.Space (50);
				GUILayout.Label(food);
				//imageBox(food);
				GUILayout.Label("NOURISHED");
				GUILayout.Space (50);
				GUILayout.Label(armour);
				//imageBox(armour);
				GUILayout.Label("NORMAL");
			GUILayout.EndHorizontal();


			GUILayout.BeginVertical();
			GUILayout.Label("ENERGY: 100%" +
			                "\nEXP: 85%" +
			                "\n$258");
			GUILayout.Space (15);
			GUILayout.Label("PVP IS OFF");
			GUILayout.EndHorizontal();


			GUI.Box(minimapRect, map);

			GUILayout.BeginArea(weaponsRect);
				GUILayout.BeginVertical();
					GUILayout.Label("1. KATANA" +
			                		"\n2. CRISS VICTOR" +
			                		"\n3. K-50M");
					GUILayout.Label(weapon);
					//imageBox2(weapon, 150, 60);
				GUILayout.EndHorizontal();
			GUILayout.EndArea();
			//GUI.DrawTexture(weaponImageRect, weapon, ScaleMode.StretchToFill, true, 10.0F);

			GUI.Label(afkRect, "YOU ARE CURRENTLY SET TO AFK AND CANNOT BE HARMED");
		}
	}

	void imageBox(Texture image){
		GUILayout.Box(image, GUILayout.Width(40), GUILayout.Height(50));
	}

	void imageBox2(Texture image){
		GUILayout.Box(image, GUILayout.Width(150), GUILayout.Height(60));
	}
	
	// Window 1
	void mainMenuWindow(int id){
		if(GUILayout.Button("CONTINUE")){

		}
		GUILayout.Space (20);
		if(GUILayout.Button("SETTINGS")){
			
		}
		GUILayout.Space (5);
		if(GUILayout.Button("INSTRUCTIONS")){
			
		}
		GUILayout.Space (20);
		if(GUILayout.Button("INVENTORY")){
			
		}
		GUILayout.Space (5);
		if(GUILayout.Button("MAP")){
			
		}
		GUILayout.Space (5);
		if(GUILayout.Button("LOGOUT")){
			
		}
	}
}
