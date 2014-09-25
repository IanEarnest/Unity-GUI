using UnityEngine;
using System.Collections;

public class LoadingLevelsMenu : MonoBehaviour {

	Rect guiRect = new Rect(Screen.width-100, Screen.height/2-75, 100, 150);

	void OnGUI(){
		GUILayout.BeginArea (guiRect);
			GUILayout.Label ("Level Select");
			if(GUILayout.Button("Level 1")){
				
			}
			if(GUILayout.Button("Level 2")){
				
			}
			if(GUILayout.Button("Level 3")){
				
			}
		GUILayout.EndArea ();
	}
}
