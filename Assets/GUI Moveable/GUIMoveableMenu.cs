using UnityEngine;
using System.Collections;

public class GUIMoveableMenu : MonoBehaviour {

	Rect guiRect = new Rect(Screen.width-100, Screen.height/2-75, 100, 150);

	void OnGUI(){
		GUILayout.BeginArea (guiRect);
			GUILayout.Label ("Moveable Select");
			if(GUILayout.Button("Default")){
				
			}
			if(GUILayout.Button("Menu setup")){
				
			}
		GUILayout.EndArea ();
	}
}
