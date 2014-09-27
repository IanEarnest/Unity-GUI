using UnityEngine;
using System.Collections;

public class OnGUIMenu : MonoBehaviour {

	public static int menuSelect = 3;
	Rect guiRect = new Rect(Screen.width-100, Screen.height/2-75, 100, 150);

	void OnGUI(){
		GUILayout.BeginArea (guiRect);
			GUILayout.Label ("OnGUI Select");
			if(GUILayout.Button("First menus")){
				menuSelect = 1;
			}
			if(GUILayout.Button("Custom menus")){
				menuSelect = 2;
			}
			if(GUILayout.Button("Color Slider")){
				menuSelect = 3;
			}
		GUILayout.EndArea ();
	}
}
