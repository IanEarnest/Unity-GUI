using UnityEngine;
using System.Collections;

public class OnGUIMenu : MonoBehaviour {

	Rect guiRect = new Rect(Screen.width-100, Screen.height/2-75, 100, 150);

	void OnGUI(){
		GUILayout.BeginArea (guiRect);
			GUILayout.Label ("OnGUI Select");
			if(GUILayout.Button("First menus")){
				
			}
			if(GUILayout.Button("Custom menus")){
				
			}
		GUILayout.EndArea ();
	}
}
