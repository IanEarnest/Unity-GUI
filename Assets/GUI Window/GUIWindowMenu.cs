using UnityEngine;
using System.Collections;

public class GUIWindowMenu : MonoBehaviour {
	public static int showWindow = 0;
	Rect guiRect = new Rect(Screen.width-100, Screen.height/2-75, 100, 150);

	void OnGUI(){
		GUILayout.BeginArea (guiRect);
			GUILayout.Label ("Window Select");
			if(GUILayout.Button("Menu 1")){
				showWindow = 1;
			}
			if(GUILayout.Button("Menu 2")){
				showWindow = 2;
			}
		GUILayout.EndArea ();
	}
}
